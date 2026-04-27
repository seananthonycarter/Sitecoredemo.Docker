using Sitecore.Diagnostics;
using Sitecore.Pipelines.RenderField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace DockerStarter.Foundation.Pipelines
{
    public class ProcessLinkField
    {
        public void Process(RenderFieldArgs args)
        {
            Assert.ArgumentNotNull(args, nameof(args));

            int deviceVersion = 11; //TODO get current device type, header, query string

            if (args.FieldTypeKey == "general link")
            {
                int minSupportDeviceForLink = GetMinimumDeviceTargetVersionFromLinkFieldValue(args.FieldValue);
                if (deviceVersion < minSupportDeviceForLink)
                {
                    args.Result.FirstPart = string.Empty;
                    args.Result.LastPart = string.Empty;
                    args.DisableWebEdit = true;
                    args.AbortPipeline();
                }
              
            }
        }

        private int GetMinimumDeviceTargetVersionFromLinkFieldValue(string xmlFieldValue)
        {
            int result = 0;
       
            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(xmlFieldValue);
                string textResult = doc.SelectSingleNode("/link")?.Attributes["minimumdevicetarget"]?.Value;
                string minNumericDevice = new String(textResult.Where(Char.IsDigit).ToArray());
                result = int.Parse(minNumericDevice);
            }
            catch { }
            return result;
        }

    }
}