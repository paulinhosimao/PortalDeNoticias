using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    
                    CriarNoticias();

                return noticias;
            }

        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Caiu o Presidente Bolsonaro",
                Autor = "Chico Simão",
                Data = DateTime.Today,
                Conteudo = "Lorem Ipsum é simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica, permanecendo essencialmente inalterado. Se popularizou na década de 60, quando a Letraset lançou decalques contendo passagens de Lorem Ipsum, e mais recentemente quando passou a ser integrado a softwares de editoração eletrônica como Aldus PageMaker."
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Pandemia de COVID-19 para o mundo",
                Autor = "Laura Campos",
                Data = DateTime.Today,
                Conteudo = "Etiam dapibus sollicitudin nulla, quis pharetra nibh gravida tempus. Ut a est tempus, finibus lorem eu, posuere magna. Vestibulum vestibulum orci leo, nec condimentum nulla vehicula eu. Aliquam facilisis, magna et volutpat sollicitudin, lectus mauris facilisis nisi, aliquam venenatis metus sem quis tortor. Aliquam vitae mauris ut massa ultricies tristique. Phasellus semper iaculis mi. Suspendisse in faucibus dui. Nunc pharetra velit egestas nibh viverra iaculis. Nunc egestas ipsum ac diam placerat, quis aliquam enim dapibus. Sed iaculis varius odio, non lobortis lectus vulputate ullamcorper. Cras et sem eu libero egestas dictum. Maecenas placerat ut quam vitae sodales. Sed laoreet a turpis et mollis."
            });

            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Economia do Brasil despenca",
                Autor = "Pedro Oliveira",
                Data = DateTime.Today,
                Conteudo = "O trecho padrão original de Lorem Ipsum, usado desde o século XVI, está reproduzido abaixo para os interessados. Seções 1.10.32 e 1.10.33 de de Finibus Bonorum et Malorum de Cicero também foram reproduzidas abaixo em sua forma exata original, acompanhada das versões para o inglês da tradução feita por H. Rackham em 1914."
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Comércio no Brasil fecha as portas",
                Autor = "Wagner Roberto",
                Data = DateTime.Today,
                Conteudo = "Várias versões novas surgiram ao longo dos anos, eventualmente por acidente, e às vezes de propósito (injetando humor, e coisas do gênero"
            });

            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Troca de Seguranças",
                Autor = "José Carlos",
                Data = DateTime.Today,
                Conteudo = "Heleno, afirmou à Polícia Federal que o presidente Jair Bolsonaro nunca teve óbices ou embaraços para nomear e trocar nomes da equipe de sua segurança pessoal no Rio de Janeiro"
            });
        }
    }
}