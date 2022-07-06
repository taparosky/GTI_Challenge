using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class ClienteController : Controller
    {
        string baseUrl = "https://localhost:7155/";
        public async Task<ActionResult> Index()
        {
            List<Cliente> clienteList = new List<Cliente>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/clientes");

                if (Res.IsSuccessStatusCode)
                {
                    var clienteResponse = Res.Content.ReadAsStringAsync().Result;
                    clienteList = JsonConvert.DeserializeObject<List<Cliente>>(clienteResponse);
                }
                return View(clienteList);
            }

        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return View("Error");
            }
            Cliente cliente = new Cliente();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUrl = "api/clientes/" + Id;
                HttpResponseMessage Res = await client.GetAsync(requestUrl);


                if (Res.IsSuccessStatusCode)
                {
                    var clienteResponse = Res.Content.ReadAsStringAsync().Result;
                    cliente = JsonConvert.DeserializeObject<Cliente>(clienteResponse);
                }
                return View(cliente);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if(cliente == null)
            {
                return View("Error");
            }

            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUrl = "api/clientes/" + cliente.Id;
                HttpResponseMessage Res = await client.PutAsJsonAsync<Cliente>(requestUrl, cliente);
                
                if(Res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View(cliente);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Cliente cliente = new Cliente();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUrl = "api/clientes/" + id;
                HttpResponseMessage Res = await client.GetAsync(requestUrl);

                if (Res.IsSuccessStatusCode)
                {
                    var clienteResponse = Res.Content.ReadAsStringAsync().Result;
                    cliente = JsonConvert.DeserializeObject<Cliente>(clienteResponse);
                }
                return View(cliente);


            }
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(Cliente cliente)
        {
            if (cliente == null)
            {
                return View("Error");
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUrl = "api/clientes/" + cliente.Id;
                HttpResponseMessage Res = await client.DeleteAsync(requestUrl);

                if (Res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View(cliente);


            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (cliente == null)
            {
                return View("Error");
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUrl = "api/clientes";
                HttpResponseMessage Res = await client.PostAsJsonAsync<Cliente>(requestUrl, cliente);

                if (Res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View(cliente);

            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Cliente cliente = new Cliente();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUrl = "api/clientes/" + id;
                HttpResponseMessage Res = await client.GetAsync(requestUrl);


                if (Res.IsSuccessStatusCode)
                {
                    var clienteResponse = Res.Content.ReadAsStringAsync().Result;
                    cliente = JsonConvert.DeserializeObject<Cliente>(clienteResponse);
                }
                return View(cliente);
            }
        }

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
