using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Net;

namespace Cartola.Sincronizador.ServicoRest
{
    public class Requisitor<T> where T : class
    {
        public string URL { get; protected set; }

        public Requisitor(string url)
        {
            URL = url;
        }

        public T Get(string urm)
        {
            try
            {
                WebRequest.DefaultWebProxy = null;

                var client = new RestClient(URL + urm);
                var request = new RestRequest(Method.GET);

                request.JsonSerializer.ContentType = "application/json; charset=utf-8";

                request.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
                //request.AddHeader("Accept-Encoding", "gzip, deflate, br");
                //request.AddHeader("Cookie", "__gads=ID=2855f2e0c058759d:T=1491095464:S=ALNI_MZbVdKz8-43SP5y0DigHMbAHLgCXA; __qca=P0-1792665476-1491095480184; nav12732=7249432d5f9cb403052c9c40409|2_322_5:4:1:3:10:14:2:9:8_2:1:2:1:BR:82-8-9-97-61-13-15:1:27:1000206; nav46169=7249432d5528026496a634de709|2_322; __tbc=%7Bjbd%7DeyJ2IjozLCJwayI6InF1NURBR2FNeVZ0dzJseTloTDRGUVNpcWlyOThrNUpoSExkcjZzZWZBTndxd21rdERPZkZrbG1ndm5HYSIsInNrIjoiR1RDb3BJRGM1eiJ9; xbc=%7Bjbd%7DeyJ2IjozLCJwayI6InF1NURBR2FNeVZ0dzJseTloTDRGUVNpcWlyOThrNUpoSExkcjZzZWZBTndxd21rdERPZkZrbG1ndm5HYSIsInNrIjoiR1RDb3BJRGM1eiJ9; CADUN_ID=\"0032255895TTMxICBMdWNhcyBIZW5uZXMgUmFuZ2VsICAgICAgICAgICA = \"; nav13574=7249432d587a507c85c02651809|2_325_5:4:1:11:14:2_1:1:1:47:102-18-97-126-82-61-13-15-8-9:1; _gat=1; hsid=2017-11-20T03:24:26-02:00; _ga=GA1.2.1008305266.1491095475; _gid=GA1.2.800487269.1511119755; glb_uid=\"7cCRBrWsKo9Ft0F9RwQjLt4NcmLQXvILvhtKA - lZNN0 = \"; utag_main=v_id:015b2c374a18004de06a784fa72c0407100730690086e$_sn:12$_ss:0$_st:1511157271358$_pn:8%3Bexp-session$ses_id:1511155468227%3Bexp-session");
                //request.AddHeader("Accept-Language", "pt-BR,pt;q=0.9,en-US;q=0.8,en;q=0.7");
                //request.AddHeader("Cache-Control", "max-age=0");
                request.AddHeader("Connection", "keep-alive");
                request.AddHeader("Host", "api.cartolafc.globo.com");
                request.AddHeader("Referer", "https://github.com/wgenial/cartrolandofc/blob/master/nova-api.md");
                request.AddHeader("Upgrade-Insecure-Requests", "1");
                request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/62.0.3202.94 Safari/537.36");

                var response = new RestResponse();
                Task.Run(async () => {
                    response = await GetResponseContentAsync(client, request) as RestResponse;
                }).Wait();

                return JsonConvert.DeserializeObject<T>(response.Content, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore });
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        protected Task<IRestResponse> GetResponseContentAsync(RestClient client, RestRequest request)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            client.ExecuteAsync(request, response => {
                tcs.SetResult(response);
            });

            return tcs.Task;
        }

    }
}
