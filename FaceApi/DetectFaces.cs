using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FP.Study.KNN.FaceApi
{
    public class DetectFaces
    {
        const string uriBase = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";

        private readonly string _imageFilePath;

        private readonly string _key;

        public DetectFaces(string imageFilePath, string subscriptionKey)
        {
            _imageFilePath = imageFilePath;
            _key = subscriptionKey;
        }

        public async Task Run()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _key);
                var requestParameters = "returnFaceId=true&returnFaceLandmarks=false&returnFaceAttributes=age,gender,smile,glasses,emotion";
                var uri = $"{uriBase}?{requestParameters}";

                var byteData = GetImageAsByteArray(_imageFilePath);

                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                    var response = await client.PostAsync(uri, content);
                    Result = await response.Content.ReadAsStringAsync();
                }
            }
        }

        public string Result { get; private set; }

        public string ResultFormated
        {
            get
            {
                dynamic parsedJson = JsonConvert.DeserializeObject(Result);
                return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
        }

        private byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (var fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                return binaryReader.ReadBytes((int) fileStream.Length);
            }
        }
    }
}
