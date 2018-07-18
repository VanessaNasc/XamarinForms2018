using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;

        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //Todo -lógica do programa

            //Todo  - validações
            string cep = CEP.Text.Trim();
            //se o cep for valido ele busca no webService
            if (isValidCEP(cep)) {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço:{2}, {3},{0} - {1}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO","O endereço nao foi encontrado para o CEP informado:"+ cep,"OK");
                    }
                   
                }catch(Exception e)
                {
                    DisplayAlert("Erro Critico", e.Message, "OK");
                }
              
                }

           
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;
            if(cep.Length != 8)
            {

                //erro
                DisplayAlert("ERRO", "Cep invalido! o CEP deve conter 8 caracteres", "OK");
                valido = false;
            }
            //verificar se o ce contem apenas numero
            int NovoCEP = 0;
            if(!int.TryParse(cep,out NovoCEP))
            {
                //erro
                DisplayAlert("ERRO", "Cep invalido! o CEP deve ser composto apenas por numeros", "OK");
                valido = false;
            }
            return valido;
        }
        
	}
}

