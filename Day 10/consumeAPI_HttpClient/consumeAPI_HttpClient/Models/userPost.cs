namespace consumeAPI_HttpClient.Models
{
    public class userPost
    {
        #region Properties
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        #endregion


        List<userPost> pList = new List<userPost>(); //we will capture the data in this variable

        public List<userPost> GetPostData()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var call = client.GetAsync(url).Result;

            if (call.IsSuccessStatusCode)
            {
                //read data
                var result = call.Content.ReadAsAsync<List<userPost>>();
                result.Wait();
                pList = result.Result;
                
            }
            else
            {
                throw new Exception("Cannot get data please contact admin");
            }

            return pList;
        }


    }
}
