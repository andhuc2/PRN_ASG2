using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PRN_ASG.Setting
{
    internal class ReadSetting
    {
        public ReadSetting() { }
        public string readUserSetting(string attrName)
        {
            string json = File.ReadAllText("appsettings.json");

            try
            {
                var jsonDocument = JsonDocument.Parse(json);
                var root = jsonDocument.RootElement;

                if (root.TryGetProperty("User", out var user))
                {
                    if (user.TryGetProperty(attrName, out var attr))
                    {
                        return attr.GetString();
                    }
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("Error parsing JSON.");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("appsettings.json not found.");
            }

            return null;
        }

        public string readConnection()
        {
            string json = File.ReadAllText("appsettings.json");

            try
            {
                var jsonDocument = JsonDocument.Parse(json);
                var root = jsonDocument.RootElement;

                if (root.TryGetProperty("ConnectionStrings", out var user))
                {
                    if (user.TryGetProperty("DbConnection", out var attr))
                    {
                        return attr.GetString();
                    }
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("Error parsing JSON.");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("appsettings.json not found.");
            }

            return null;
        }

    }
}
