using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    class Jogo
    {
        private int gameCode;
        private string gameName;
        private string gameCategory;
        private DateTime gameReleaseDate;

        public int GameCode
        {
            get => gameCode;
            set { 
             if (GameCode <= 0)
                //throw new Exception("Código deve ser " +
                //"maior que zero!");
                MessageBox.Show("Código deve ser maior que zero");
            else
                gameCode = GameCode;
            }

        }

        public string GameName
        {
            get => gameName;
            set
            {
                if (GameName.Trim().Length > 2)
                    gameName = GameName;
                else
                    //throw new Exception("Nome deve ter ao menos 2 dígitos.");
                    MessageBox.Show("Nome deve ter ao menos 2 dígitos.");
            }
        }

        public string GameCategory
        {
            get => gameCategory;
            set
            {
                if (string.IsNullOrEmpty(GameCategory))
                    MessageBox.Show("Informe a categoria!");
                //throw new Exception("Informe a categoria!");
                else
               if (GameCategory != "ação" || GameCategory != "luta" || GameCategory != "tiro" || GameCategory != "esportes")
                    MessageBox.Show("válido apenas categoria de “ação”  “luta” “tiro” e “Esportes”");
                else
                    gameCategory = GameCategory;
            }
        }

        public DateTime GameReleaseDate
        {
            get => gameReleaseDate;
            set
            {
                if (GameReleaseDate > DateTime.Now)
                    throw new Exception("Não lançou ainda!");
                else
                    this.gameReleaseDate = GameReleaseDate;
            }
        }

        public void showData()
        {
            if (this.gameCode != null && this.gameName != null && this.gameCategory != null && this.gameReleaseDate != null)
            {
                var data = "\nCódigo: " + this.gameCode + "\nNome: " + this.gameName + "\nCategoria: " + this.gameCategory + "\nData de lançamento: " + this.gameReleaseDate;
                MessageBox.Show(data);
            }
        }

        public override string ToString()
        {
            return "\nCódigo: " + this.gameCode + "\nNome: " + this.gameName + "\nCategoria: " + this.gameCategory + "\nData de lançamento: " + this.gameReleaseDate;

        }
    }
}
