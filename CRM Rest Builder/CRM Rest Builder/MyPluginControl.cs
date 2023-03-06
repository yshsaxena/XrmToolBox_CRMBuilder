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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using AttributeDetails = CRM_Rest_Builder.AttributeDetails;

namespace CRM_Rest_Builder
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        RetrieveEntityResponse metaDataEntityResponse = new RetrieveEntityResponse();
        Dictionary<string, string> entityNames = new Dictionary<string, string>();
        Dictionary<string, AttributeDetails> AttributeDetailsList = new Dictionary<string, AttributeDetails>();

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
            //ExecuteMethod(getEntityDetails);

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

        //private void getEntityDetails()
        //{
        //    WorkAsync(new WorkAsyncInfo
        //    {
        //        Work = (worker, args) =>
        //        {


        //        },
        //        PostWorkCallBack = (args) =>
        //        {

        //        }
        //    });
        //}

        public async Task GetEntityDetails()
        {
            foreach (var item in metaDataEntityResponse.EntityMetadata.Attributes)
            {
                AttributeDetails attributeObj = new AttributeDetails();
                attributeObj.EntityPluralName = metaDataEntityResponse.EntityMetadata.LogicalCollectionName.ToString();
                attributeObj.attributeLogicalName = item.LogicalName.ToString();
                attributeObj.attributeType = item.AttributeType.ToString();
                AttributeDetailsList.Add(item.LogicalName.ToString(), attributeObj);
            }

        }

        public async Task getEntityDetailsAsynchronously()
        {
            await GetEntityDetails();
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

            Task task = getEntityDetailsAsynchronously();

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

        private void rdoWebApi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWebApi.Checked)
            {
                rdoAsync.Checked = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblSynchronous_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoWebApi.Checked)
            {
                rdoAsync.Checked = true;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Execute_Click(object sender, EventArgs e)
        {

            var entityLogicalName = cmbEntity.Text;
            labelCopied.Visible = false;
            List<string> checkedColumnList = new List<string>();
            checkedColumnList.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (AttributeDetailsList[item.ToString()].attributeType == "Lookup")
                {
                    checkedColumnList.Add("_" + item.ToString() + "_value");
                }
                else
                {
                    checkedColumnList.Add(item.ToString());
                }
            }

            var equal = string.Empty;
            if (AttributeDetailsList[CmbFilter.Text].attributeType == "String")
            {
                equal = "'" + textBoxEqual.Text + "'";
            }
            else
            {
                equal = textBoxEqual.Text;
            }

            var isAsync = false;
            if (rdoAsync.Checked == true)
            {
                isAsync = true;
            }
            else
            {
                isAsync = false;
            }

            StringBuilder str = new StringBuilder();

            if (rdoXmlHttp.Checked == true)
            {
                str.AppendLine("var req = new XMLHttpRequest();");
                str.AppendLine("req.open(\"GET\", Xrm.Page.context.getClientUrl() +" + "\"/api/data/v9.1/" + AttributeDetailsList[CmbFilter.Text].EntityPluralName + "?$select=" + String.Join(",", checkedColumnList) + "&$filter=" + CmbFilter.Text + " eq " + equal + "\", " + isAsync.ToString().ToLower() + ");");
                str.AppendLine("req.setRequestHeader(\"OData - MaxVersion\", \"4.0\");");
                str.AppendLine("req.setRequestHeader(\"OData - Version\", \"4.0\");");
                str.AppendLine("req.setRequestHeader(\"Accept\", \"application / json\");");
                str.AppendLine("req.setRequestHeader(\"Content - Type\", \"application / json; charset = utf - 8\");");
                str.AppendLine("req.setRequestHeader(\"Prefer\", \"odata.include - annotations =\"*\"\"); ");
                str.AppendLine("req.onreadystatechange = function() {");
                str.AppendLine("    if (this.readyState === 4) {");
                str.AppendLine("        req.onreadystatechange = null;");
                str.AppendLine("        if (this.status === 200) {");
                str.AppendLine("            var results = JSON.parse(this.response);");
                str.AppendLine("            for (var i = 0; i < results.value.length; i++) {");
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    if (AttributeDetailsList[item.ToString()].attributeType == "Lookup")
                    {
                        str.AppendLine("                var " + "_" + item.ToString() + "_value" + " = results.value[i][\"" + "_" + item.ToString() + "_value" + "\"];");
                        str.AppendLine("                var " + "_" + item.ToString() + "_value" + "_formatted = results.value[i][\"" + "_" + item.ToString() + "_value" + "@OData.Community.Display.V1.FormattedValue\"];");
                        str.AppendLine("                var " + "_" + item.ToString() + "_value" + "_lookuplogicalname = results.value[i][\"" + "_" + item.ToString() + "_value" + "@Microsoft.Dynamics.CRM.lookuplogicalname\"];");
                    }
                    else
                    {
                        str.AppendLine("                var " + item + " = results.value[i][\"" + item + "\"];");
                    }
                }
                str.AppendLine("            }");
                str.AppendLine("        } else {");
                str.AppendLine("            Xrm.Utility.alertDialog(this.statusText);");
                str.AppendLine("        }");
                str.AppendLine("    }");
                str.AppendLine("};");
                str.AppendLine("req.send();");
            }
            else if (rdoWebApi.Checked == true)
            {
                str.AppendLine("Xrm.WebApi.online.retrieveMultipleRecords(\"" + cmbEntity.Text + "\", \"?$select=" + String.Join(",", checkedColumnList) + "&$filter=" + CmbFilter.Text + " eq " + equal + "\").then(");
                str.AppendLine("    function success(results) {");
                str.AppendLine("        for (var i = 0; i < results.entities.length; i++) {");
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    if (AttributeDetailsList[item.ToString()].attributeType == "Lookup")
                    {
                        str.AppendLine("                var " + "_" + item.ToString() + "_value" + " = results.value[i][\"" + "_" + item.ToString() + "_value" + "\"];");
                        str.AppendLine("                var " + "_" + item.ToString() + "_value" + "_formatted = results.value[i][\"" + "_" + item.ToString() + "_value" + "@OData.Community.Display.V1.FormattedValue\"];");
                        str.AppendLine("                var " + "_" + item.ToString() + "_value" + "_lookuplogicalname = results.value[i][\"" + "_" + item.ToString() + "_value" + "@Microsoft.Dynamics.CRM.lookuplogicalname\"];");
                    }
                    else
                    {
                        str.AppendLine("                var " + item + " = results.value[i][\"" + item + "\"];");
                    }
                }
                str.AppendLine("        }");
                str.AppendLine("    },");
                str.AppendLine("    function(error) {");
                str.AppendLine("        Xrm.Utility.alertDialog(error.message);");
                str.AppendLine("    }");
                str.AppendLine(");");

            }


            richTextBox_Code.Text = str.ToString();

            ConditionExpression condition1 = new ConditionExpression();
            condition1.AttributeName = CmbFilter.Text;
            condition1.Operator = ConditionOperator.Equal;
            condition1.Values.Add(textBoxEqual.Text);

            //ConditionExpression condition2 = new ConditionExpression();
            //condition2.AttributeName = "firstname";
            //condition2.Operator = ConditionOperator.Equal;
            //condition2.Values.Add("Alexis");

            FilterExpression filter1 = new FilterExpression();
            filter1.Conditions.Add(condition1);

            QueryExpression query = new QueryExpression(cmbEntity.Text);
            query.ColumnSet.AddColumns(checkedListBox1.CheckedItems.OfType<string>().ToArray());//"firstname", "lastname"
            query.Criteria.AddFilter(filter1);

            EntityCollection result = new EntityCollection();

            if (textBoxEqual.Text != null)
            {
                try
                {
                    result = Service.RetrieveMultiple(query);
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            StringBuilder strResult = new StringBuilder();
            strResult.AppendLine("[");
            var count = 0;
            foreach (var item in result.Entities)
            {
                count++;
                strResult.AppendLine("     {");
                foreach (var item2 in item.Attributes.Keys)
                {
                    strResult.AppendLine("         " + item2 + ": \"" + item.Attributes[item2] + "\"");
                }
                strResult.AppendLine("     }");
                if (count != result.Entities.Count)
                {
                    strResult.Append(" ,");
                }
            }
            strResult.AppendLine("]");
            richTextBox_Result.Text = strResult.ToString();
            //foreach (var a in result1.Entities)
            //{
            //    Console.WriteLine("Name: " + a.Attributes["firstname"] + " " + a.Attributes["lastname"]);
            //}


        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox_Code.Text != null)
            {
                Clipboard.SetText(richTextBox_Code.Text);
                labelCopied.Visible = true;
            }
        }

        private void labelCopied_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_Code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}