using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Cinema
{
    public static class Utility
    {
        public static T MakeRequest<T>(string requestUrl,bool useJavaScriptSerializer=false)
        {
            /*
             T si può dare un vincolo di tipo con la sintassi
             Where T : System.Icomparable<T>
             ma ti deve essere di questo tipo
             */
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                /* as ci permette di fare un cast al volo http web request*/

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                string responseString = string.Empty;
                if (useJavaScriptSerializer)
                {
                      JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                    using ( StreamReader reader = new StreamReader(response.GetResponseStream())) {




                        return jsSerializer.Deserialize<T>(reader.ReadToEnd());

                    }

                    
                        
                    
                     

                }
                DataContractJsonSerializer serialized = new DataContractJsonSerializer(typeof(T));
                return (T)serialized.ReadObject(response.GetResponseStream());
                
                //XmlDocument xmldoc = new XmlDocument();
                //xmldoc.Load(response.GetResponseStream());



            }
            catch (HttpListenerException e)
            { return default(T); }
            
            catch (InvalidOperationException ex)
            { return default(T); }
        }
    }
}
