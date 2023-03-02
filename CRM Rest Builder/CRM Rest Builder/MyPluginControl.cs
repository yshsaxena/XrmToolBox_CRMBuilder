using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace CRM_Rest_Builder
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        RetrieveEntityResponse metaDataEntityResponse = new RetrieveEntityResponse();
        Dictionary<string, string> entityNames = new Dictionary<string, string>();

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> attributesData = new Dictionary<string, string>();
            RetrieveAllEntitiesRequest metaDataRequest = new RetrieveAllEntitiesRequest();
            RetrieveAllEntitiesResponse metaDataResponse = new RetrieveAllEntitiesResponse();
            metaDataRequest.EntityFilters = EntityFilters.Entity;

            // Execute the request.

            metaDataResponse = (RetrieveAllEntitiesResponse)Service.Execute(metaDataRequest);

            var entities = metaDataResponse.EntityMetadata;

            Dictionary<String, String> list = new Dictionary<string, string>();

            foreach (var item in entities)
            {
                if (item.LogicalName != null)
                {
                    cmbEntity.Items.Add(item.LogicalName);
                }
            }

            //ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            //// Loads or creates the settings for the plugin
            //if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            //{
            //    mySettings = new Settings();

            //    LogWarning("Settings not found => a new settings file has been created!");
            //}
            //else
            //{
            //    LogInfo("Settings found and loaded");
            //}
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetrieveEntityRequest metaDataEntityRequest = new RetrieveEntityRequest
            {
                // csv  contactnumber telephone2 require numeric
                // csv contactnumber AmitYash
                EntityFilters = EntityFilters.Attributes,//required /nonrequired , dataype (lookup, numberic,string)
                LogicalName = cmbEntity.Text,
                //ExtensionData = Entityname,
                RetrieveAsIfPublished = true

            };
            //  Entity RetrievedEntityById = svc.Retrieve(entities[i].LogicalName, guid, new ColumnSet(true)); //it will retrieve the all attrributes
            metaDataEntityResponse = (RetrieveEntityResponse)Service.Execute(metaDataEntityRequest);

            var entityFieldName = metaDataEntityResponse;

            checkedListBox1.Items.Clear();
            CmbFilter.Items.Clear();

            foreach (var item in metaDataEntityResponse.EntityMetadata.Attributes)
            {
                checkedListBox1.Items.Add(item.LogicalName);
                CmbFilter.Items.Add(item.LogicalName);//entityFieldName.Results.Values).Items[0])).Attributes[0]
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}