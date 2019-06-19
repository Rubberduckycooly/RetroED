using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroED.Extensions.EntityToolbar
{
    public partial class EntityToolbar : UserControl
    {
        public Action<int> SelectedEntity;
        public Action<RetroED.Tools.MapEditor.Actions.IAction> AddAction;
        public Action<Retro_Formats.Object> Spawn;

        public bool multipleObjects = false;

        public RetroED.Tools.MapEditor.MainView parent;

        public Retro_Formats.EngineType engineType;

        public List<Retro_Formats.Object> _entities = new List<Retro_Formats.Object>();
        private List<int> _selectedEntitySlots = new List<int>();
        private BindingSource _bindingSceneObjectsSource = new BindingSource();

        public Retro_Formats.Scene SceneData
        {
            get { return parent.Scene; }
            set { parent.Scene = value; }
        }

        private Retro_Formats.Object currentEntity;

        public List<Retro_Formats.Object> Entities
        {
            get
            {
                return _entities;
            }
            set
            {
                _entities = value.ToList();
                _entities.Sort((x, y) => x.id.CompareTo(y.id));
                UpdateEntitiesList();
            }
        }

        bool updateSelected = true;

        public List<Retro_Formats.Object> SelectedEntities
        {
            set
            {
                UpdateEntitiesProperties(value);
            }
        }

        public bool NeedRefresh;

        public EntityToolbar()
        {
            InitializeComponent();
        }

        public EntityToolbar(List<Retro_Formats.Object> sceneObjects, RetroED.Tools.MapEditor.MainView p)
        {
            parent = p;
            InitializeComponent();
            RefreshObjects(sceneObjects);
        }

        private void UpdateEntitiesList()
        {
            entitiesList.Items.Clear();
            entitiesList.ResetText();

            if (currentEntity != null && _entities.Contains(currentEntity))
            {
                entitiesList.SelectedText = String.Format("{0} - {1}", currentEntity.id, currentEntity.Name);
            }
        }

        public void RefreshObjects(List<Retro_Formats.Object> sceneObjects)
        {
            _entities = SceneData.objects;
            sceneObjects.Sort((x, y) => x.Name.ToString().CompareTo(y.Name.ToString()));
            var bindingSceneObjectsList = new BindingList<Retro_Formats.Object>(sceneObjects);
            _bindingSceneObjectsSource.DataSource = bindingSceneObjectsList;

            if (_bindingSceneObjectsSource != null && _bindingSceneObjectsSource.Count > 0)
            {
                cbSpawn.DataSource = _bindingSceneObjectsSource;
                cbSpawn.SelectedIndex = 0;
            }
        }

        public void entitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String input = entitiesList.Text.ToString();
            ///string output = new string(input.TakeWhile(char.IsDigit).ToArray());
            //int selectedIndex = Int32.Parse(output);
            //int selectedSlotID = GetIndexOfSlotID(selectedIndex);


            /*if (updateSelected && !multipleObjects) SelectedEntity?.Invoke(_entities[entitiesList.SelectedIndex].SlotID);*/
            /*if (updateSelected && multipleObjects) SelectedEntity?.Invoke(_entities[selectedSlotID].SlotID);*/

            SelectedEntity?.Invoke(_entities[entitiesList.SelectedIndex].id);
            List<Retro_Formats.Object> se = new List<Retro_Formats.Object>();
            se.Add(_entities[entitiesList.SelectedIndex]);
            UpdateEntitiesProperties(se);
        }

        public int GetIndexOfSlotID(int slotID)
        {
            int index = 0;

            for (int i = 0; i < _entities.Count; i++)
            {
                if (_entities[i].id == (ushort)slotID)
                {
                    index = i;
                }
            }
            return index;
        }

        private void addProperty(LocalProperties properties, int category_index, string category, string name, string value_type, object value, bool read_only = false)
        {
            properties.Add(String.Format("{0}.{1}", category, name),
                    new LocalProperty(name, value_type, category_index, category, name, true, read_only, value, "")
                );
        }

        private void UpdateEntitiesProperties(List<Retro_Formats.Object> selectedEntities)
        {
            multipleObjects = false;
            bool isCommonObjects = false;

            if (selectedEntities.Count != 1)
            {
                entityProperties.SelectedObject = null;
                currentEntity = null;
                entitiesList.ResetText();
                _selectedEntitySlots.Clear();
                if (selectedEntities.Count > 1)
                {
                    isCommonObjects = true;
                    entitiesList.SelectedText = String.Format("{0} entities selected", selectedEntities.Count);
                    entitiesList.Items.Clear();
                    entitiesList.DisplayMember = "Text";
                    entitiesList.Tag = "Value";
                    foreach (Retro_Formats.Object selectedEntity in selectedEntities)
                    {

                        entitiesList.Items.Add(new { Text = (String.Format("{0} - {1}", selectedEntity.id, selectedEntity.Name)), Value = selectedEntity.id });
                        _selectedEntitySlots.Add(selectedEntity.id);
                    }
                    //entitiesList.Items.AddRange(selectedEntities.Select(x => String.Format("{0} - {1}", x.SlotID, x.Object.Name)).ToArray());
                    multipleObjects = true;
                    //_selectedEntitySlots.AddRange(selectedEntities.Select(x => (int)x.SlotID).ToList());
                    string commonObject = selectedEntities[0].Name;
                    foreach (Retro_Formats.Object selectedEntity in selectedEntities)
                    {
                        if (selectedEntity.Name != commonObject)
                        {
                            isCommonObjects = false;
                        }
                    }

                }
                if (isCommonObjects == true)
                {
                    //Keep Going (if Implemented; which it's not)
                   // return;
                }
                else
                {
                    //return;
                }

            }

            Retro_Formats.Object entity = selectedEntities[0];

            if (entity == currentEntity) return;
            currentEntity = entity;

            if (entitiesList.SelectedIndex >= 0 && entitiesList.SelectedIndex < _entities.Count && _entities[entitiesList.SelectedIndex] == currentEntity)
            {
                // Than it is called from selected item in the menu, so changeing the text will remove it, we don't want that
            }
            else
            {
                entitiesList.ResetText();
                entitiesList.SelectedText = String.Format("{0} - {1}", currentEntity.id, currentEntity.Name);
                //entitiesList.SelectedIndex = entities.IndexOf(entity);
            }


            LocalProperties objProperties = new LocalProperties();
            int category_index = 3;//+ entity.Attributes.Count;
            if (engineType == Retro_Formats.EngineType.RSDKvB) category_index = 4;
            addProperty(objProperties, category_index, "object", "name", "string", entity.Name.ToString(), false);
            addProperty(objProperties, category_index, "object", "entitySlot", "ushort", entity.id, false);
            --category_index;
            addProperty(objProperties, category_index, "position", "x", "ushort", entity.xPos);
            addProperty(objProperties, category_index, "position", "y", "ushort", entity.yPos);
            --category_index;
            addProperty(objProperties, category_index, "type", "Type", "byte", entity.type);
            addProperty(objProperties, category_index, "type", "PropertyValue", "byte", entity.subtype);
            --category_index;
            if (engineType == Retro_Formats.EngineType.RSDKvB)
            {
                addProperty(objProperties, category_index, "attribute", "attributeType", "ushort", entity.AttributeType);
                addProperty(objProperties, category_index, "attribute", "attributeValue 1", "uint", entity.attributes[0]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 2", "uint", entity.attributes[1]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 3", "uint", entity.attributes[2]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 4", "byte", entity.attributes[3]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 5", "byte", entity.attributes[4]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 6", "byte", entity.attributes[5]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 7", "uint", entity.attributes[6]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 8", "uint", entity.attributes[7]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 9", "byte", entity.attributes[8]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 10", "uint", entity.attributes[9]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 11", "uint", entity.attributes[10]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 12", "uint", entity.attributes[11]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 13", "uint", entity.attributes[12]);
                addProperty(objProperties, category_index, "attribute", "attributeValue 14", "uint", entity.attributes[13]);
                --category_index;
            }

            entityProperties.SelectedObject
                = new LocalPropertyGridObject(objProperties);
        }

        public void UpdateCurrentEntityProperites()
        {
            var obj = entityProperties.SelectedObject as LocalPropertyGridObject;
            if (obj != null)
            {

                obj.setValue("position.x", currentEntity.xPos);
                obj.setValue("position.y", currentEntity.yPos);
                obj.setValue("type.Type", currentEntity.type);
                obj.setValue("type.PropertyValue", currentEntity.subtype);
                if (engineType == Retro_Formats.EngineType.RSDKvB)
                {
                    obj.setValue("attribute.attributeType", currentEntity.AttributeType);
                    obj.setValue("attribute.attributeValue 1", currentEntity.attributes[0]);
                    obj.setValue("attribute.attributeValue 2", currentEntity.attributes[1]);
                    obj.setValue("attribute.attributeValue 3", currentEntity.attributes[2]);
                    obj.setValue("attribute.attributeValue 4", currentEntity.attributes[3]);
                    obj.setValue("attribute.attributeValue 5", currentEntity.attributes[4]);
                    obj.setValue("attribute.attributeValue 6", currentEntity.attributes[5]);
                    obj.setValue("attribute.attributeValue 7", currentEntity.attributes[6]);
                    obj.setValue("attribute.attributeValue 8", currentEntity.attributes[7]);
                    obj.setValue("attribute.attributeValue 9", currentEntity.attributes[8]);
                    obj.setValue("attribute.attributeValue 10", currentEntity.attributes[9]);
                    obj.setValue("attribute.attributeValue 11", currentEntity.attributes[10]);
                    obj.setValue("attribute.attributeValue 12", currentEntity.attributes[11]);
                    obj.setValue("attribute.attributeValue 13", currentEntity.attributes[12]);
                    obj.setValue("attribute.attributeValue 14", currentEntity.attributes[13]);
                }
                NeedRefresh = true;
                parent._mapViewer.DrawScene();
            }
        }

        public void PropertiesRefresh()
        {
            entityProperties.Refresh();
            NeedRefresh = false;
        }

        private void setEntitiyProperty(Retro_Formats.Object entity, string tag, object value, object oldValue)
        {
            string[] parts = tag.Split('.');
            string category = parts[0];
            string name = parts[1];
            if (category == "position")
            {
                float fvalue = Convert.ToInt32(value);
                if (fvalue < Int16.MinValue || fvalue > Int16.MaxValue)
                {
                    // Invalid
                    var obj = (entityProperties.SelectedObject as LocalPropertyGridObject);
                    obj.setValue(tag, oldValue);
                    return;
                }
                if (engineType != Retro_Formats.EngineType.RSDKvB)
                {
                    if (name == "x")
                    {
                        entity.xPos = (short)fvalue;
                    }
                    else if (name == "y")
                    {
                        entity.yPos = (short)fvalue;
                    }
                }
                else
                {
                    if (name == "x")
                    {
                        entity.position.X.High = (short)fvalue;
                        entity.position.X.Low = (ushort)(fvalue * 0x10000);
                    }
                    else if (name == "y")
                    {
                        entity.position.X.High = (short)fvalue;
                        entity.position.X.Low = (ushort)(fvalue * 0x10000);
                    }
                }
                if (entity == currentEntity)
                    UpdateCurrentEntityProperites();
            }
            else if (category == "type")
            {
                byte fvalue = Convert.ToByte(value);
                if (fvalue < byte.MinValue || fvalue > byte.MaxValue)
                {
                    // Invalid
                    var obj = (entityProperties.SelectedObject as LocalPropertyGridObject);
                    obj.setValue(tag, oldValue);
                    return;
                }

                var type = entity.type;
                var subtype = entity.subtype;
                if (name == "Type")
                {
                    type = fvalue;
                }
                else if (name == "PropertyValue")
                {
                    subtype = fvalue;
                }
                entity.type = type;
                entity.subtype = subtype;
                if (entity == currentEntity)
                    UpdateCurrentEntityProperites();
            }
            else if (category == "object")
            {
                if (name == "name" && oldValue != value)
                {
                    var objects = ((BindingList<Retro_Formats.Object>)_bindingSceneObjectsSource.DataSource).ToList();
                    var obj = objects.FirstOrDefault(t => t.Name == value as string);
                }
                if (name == "entitySlot" && oldValue != value)
                {
                    int tmp = (Int32)value;
                    ushort newSlot = (ushort)tmp;
                    // Check if slot has been used
                    var objects = ((BindingList<Retro_Formats.Object>)_bindingSceneObjectsSource.DataSource).ToList();
                    foreach (var obj in objects)
                    {
                        if (obj.id == newSlot)
                        {
                            System.Windows.Forms.MessageBox.Show($"Slot {newSlot} is currently being used by a {obj.Name.ToString()}",
                                "Slot in use!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    // Passed
                    entity.id = newSlot;
                }
                // Update Properties
                currentEntity = null;
                UpdateEntitiesProperties(new List<Retro_Formats.Object>() { entity });
            }
            else if (category == "attribute")
            {
                uint fvalue = Convert.ToUInt32(value);
                if (fvalue < uint.MinValue || fvalue > uint.MaxValue)
                {
                    // Invalid
                    var obj = (entityProperties.SelectedObject as LocalPropertyGridObject);
                    obj.setValue(tag, oldValue);
                    return;
                }

                if (name == "attributeType")
                {
                    entity.AttributeType = (ushort)fvalue;
                }
                else if (name == "attributeValue 1")
                {
                    entity.attributes[0] = fvalue;
                }
                else if (name == "attributeValue 2")
                {
                    entity.attributes[1] = fvalue;
                }
                else if (name == "attributeValue 3")
                {
                    entity.attributes[2] = fvalue;
                }
                else if (name == "attributeValue 4")
                {
                    entity.attributes[3] = fvalue;
                }
                else if (name == "attributeValue 5")
                {
                    entity.attributes[4] = fvalue;
                }
                else if (name == "attributeValue 6")
                {
                    entity.attributes[5] = fvalue;
                }
                else if (name == "attributeValue 7")
                {
                    entity.attributes[6] = fvalue;
                }
                else if (name == "attributeValue 8")
                {
                    entity.attributes[7] = fvalue;
                }
                else if (name == "attributeValue 9")
                {
                    entity.attributes[8] = fvalue;
                }
                else if (name == "attributeValue 10")
                {
                    entity.attributes[9] = fvalue;
                }
                else if (name == "attributeValue 11")
                {
                    entity.attributes[10] = fvalue;
                }
                else if (name == "attributeValue 12")
                {
                    entity.attributes[11] = fvalue;
                }
                else if (name == "attributeValue 13")
                {
                    entity.attributes[12] = fvalue;
                }
                else if (name == "attributeValue 14")
                {
                    entity.attributes[13] = fvalue;
                }

                if (entity == currentEntity)
                    UpdateCurrentEntityProperites();
            }
        }

        private void entityProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            string tag = e.ChangedItem.PropertyDescriptor.Name;

            AddAction?.Invoke(new RetroED.Tools.MapEditor.Actions.ActionEntityPropertyChange(currentEntity, tag, e.OldValue, e.ChangedItem.Value, new Action<Retro_Formats.Object, string, object, object>(setEntitiyProperty)));
            setEntitiyProperty(currentEntity, tag, e.ChangedItem.Value, e.OldValue);
        }

        private void entitiesList_DropDown(object sender, EventArgs e)
        {
            // It is slow to update the list, so lets generate it when the menu opens
            entitiesList.Items.Clear();
            entitiesList.Items.AddRange(_entities.Select(x => String.Format("{0} - {1}", x.id, x.Name)).ToArray());
        }

        private void btnSpawn_Click(object sender, EventArgs e)
        {
            if (cbSpawn?.SelectedItem != null && cbSpawn.SelectedItem is Retro_Formats.Object)
            {
                if ((SceneData.objects.Count + 1) < SceneData.MaxObjectCount)
                {
                    Retro_Formats.Object Obj = cbSpawn.SelectedItem as Retro_Formats.Object;
                    Obj.id = (ushort)_entities.Count;
                    _entities.Add(Obj);
                }
                else
                {
                    MessageBox.Show("You've exceeded the max amount of objects for this stage! Remove objects to spawn a new one!");
                }
            }
        }

        private void cbSpawn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSpawn_Click(sender, e);
            }
        }
    }
}
