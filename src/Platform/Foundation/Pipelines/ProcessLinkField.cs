using Sitecore.Diagnostics;
using Sitecore.Pipelines.RenderField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DockerStarter.Foundation.Pipelines
{
    public class ProcessLinkField
    {
        public void Process(RenderFieldArgs args)
        {
            Assert.ArgumentNotNull(args, nameof(args));
            if ((args.FieldTypeKey != "general link with search" && args.FieldTypeKey != "general link") || args.FieldTypeKey != "rich text" || string.IsNullOrWhiteSpace(args.Result.FirstPart))
            {
                return;
            }

            args.Result.FirstPart = UpdateToken(args.Result.FirstPart);
            args.Result.LastPart = args.Result.LastPart;
        }

        private string UpdateToken(string fieldValue)
        {
            if (fieldValue.Contains("$$contactid$$"))
            {
                fieldValue = GetTokenUpdateLink(fieldValue);
            }
            return fieldValue;
        }

        public static string GetTokenUpdateLink(string url)
        {

            try
            {
                var contactId = "contact id"; // write logic to get the contact id;
                return url.Replace("$$contactid$$", contactId);
            }
            catch (Exception ex)
            {
                Log.Error("Issue with update token value for link" + ex.Message, true);
            }
            return url;
        }

        /// <summary>
        /// Checks if the field should not be handled by the processor.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>true if the field should not be handled by the processor; otherwise false</returns>
        protected virtual bool SkipProcessor(RenderFieldArgs args)
        {
            if (args == null)
            {
                return true;
            }

            string fieldTypeKey = args.FieldTypeKey;
            if (fieldTypeKey != "link")
            {
                return fieldTypeKey != "general link";
            }

            return false;
        }
    }
}