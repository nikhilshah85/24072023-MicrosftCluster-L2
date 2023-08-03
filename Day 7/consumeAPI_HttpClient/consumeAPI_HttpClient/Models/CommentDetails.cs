namespace consumeAPI_HttpClient.Models
{
    public class CommentDetails
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        List<CommentDetails> commentList = new List<CommentDetails>();

        public List<CommentDetails> GetComments()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string url = "https://jsonplaceholder.typicode.com/comments";

            var call = client.GetAsync(url).Result; //this will make a call and we get statuscode and call details as result

            if (call.IsSuccessStatusCode) //if status code is 200, we will read the data,else exception
            {
                var data = call.Content.ReadAsAsync<List<CommentDetails>>();
                data.Wait(); //wait for all the data to come and read for the call to get over, since data will come in chuck for Asyn calls
                commentList = data.Result;
                return commentList;
            }
            else
            {
                throw new Exception("Could not get data, please contact admin");
            }

        }

    }
}
