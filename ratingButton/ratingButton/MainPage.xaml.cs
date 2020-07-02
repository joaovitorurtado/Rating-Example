using System;
using System.ComponentModel;
using ratingButton.DBO;
using Xamarin.Forms;


namespace ratingButton
{
    public partial class MainPage : ContentPage
    {
        float votos = 0;
        float num = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        public void seClicar1(object sender, EventArgs args)
        {
            num += 1;
            confirmarVoto(votos, num);
            
        }
        public void seClicar2(object sender, EventArgs args)
        {
            num += 2;
            confirmarVoto(votos, num);
        }
        public void seClicar3(object sender, EventArgs args)
        {
            num += 3;
            confirmarVoto(votos, num);
        }
        public void seClicar4(object sender, EventArgs args)
        {
            num += 4;
            confirmarVoto(votos, num);

        }
        public void seClicar5(object sender, EventArgs args)
        {
            num += 5;
            confirmarVoto(votos, num);
        }

        async void confirmarVoto(float votos, float num)
        {
            bool pergunta = await DisplayAlert("Voto", "Você está certo com seu voto", "Sim", "Não");
            if(pergunta == true)
            {
                votos++;
                float rating = bollConfirmarVoto(votos, num);
                labelNumero.Text = rating.ToString();
                if (rating < 5 && rating >= 4)
                {
                    Console.WriteLine(rating);
                    estrelaaaaa.Source = "whiteStar.png";
                    estrelaaaa.Source = "blackStar.png";
                    estrelaaa.Source = "blackStar.png";
                    estrelaa.Source = "blackStar.png";
                    estrela.Source = "blackStar.png";

                }
                else if(rating < 4 && rating >= 3) {
                  estrelaaaaa.Source = "whiteStar.png";
                    estrelaaaa.Source = "whiteStar.png";
                    estrelaaa.Source = "blackStar.png";
                    estrelaa.Source = "blackStar.png";
                    estrela.Source = "blackStar.png";
                    Console.WriteLine(rating);
                }
                else if (rating < 3 && rating >= 2)
                {
                    estrelaaaaa.Source = "whiteStar.png";
                    estrelaaaa.Source = "whiteStar.png";
                    estrelaaa.Source = "whiteStar.png";
                    estrelaa.Source = "blackStar.png";
                    estrela.Source = "blackStar.png";
                    Console.WriteLine(rating);
                } else if(rating < 2 && rating >= 1)
                {
                    estrelaaaaa.Source = "whiteStar.png";
                    estrelaaaa.Source = "whiteStar.png";
                    estrelaaa.Source = "whiteStar.png";
                    estrelaa.Source = "whiteStar.png";
                    estrela.Source = "blackStar.png";
                    Console.WriteLine(rating);
                }
                else if(rating < 1 && rating >= 0)
                {
                    estrelaaaaa.Source = "whiteStar.png";
                    estrelaaaa.Source = "whiteStar.png";
                    estrelaaa.Source = "whiteStar.png";
                    estrelaa.Source = "whiteStar.png";
                    estrela.Source = "whiteStar.png";
                }
                else
                {
                    estrelaaaaa.Source = "blackStar.png";
                    estrelaaaa.Source = "blackStar.png";
                    estrelaaa.Source = "blackStar.png";
                    estrelaa.Source = "blackStar.png";
                    estrela.Source = "blackStar.png";
                }


            }         
        }
        public float bollConfirmarVoto(float votos, float num)
        {
            float aux;
            this.votos = votos;
            aux = (num/votos);
            return aux;
        }
    }

}
