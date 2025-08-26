

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "arquivo"); //classe "path" serve para criar um caminho apartir de 2 elementos.
        public MainPage()
        {
            InitializeComponent(); //responsavel por guardar os codigos do UI (labels, buttons, e os krl)
            if (File.Exists(caminho)) // "existe este arquivo nesse caminho?"
            CaixaEditor.Text = File.ReadAllText(caminho); //se sim = leia + locãção do texto
        
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            String conteudo = CaixaEditor.Text;
            File.WriteAllText(caminho, conteudo);
        DisplayAlert("O arquivo foi salvo com sucesso", $"{caminho}", "ok");  //exibir nome do arq salvo e o local!
        }
        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {

            CaixaEditor.Text = ""; //limpa a caixa de texto. ponto 
            if (File.Exists(caminho))
            {
                File.Delete(caminho); //deleta o texto q fora escrito.
                DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "Ok :( ");
            } //mostra que apagou uau 
            else
            {
            DisplayAlert("Aquivo nao existe", "Arquivo nao encontrado", "Ok");
               //SE nao existir, AVISAR
            }



                

        }

        
    }

}
