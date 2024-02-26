using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Software_Hero
{
    public partial class Form2 : Form
    {
       //private const string SoundLocation = @"E:\Etec\2-ano\Curso\DS\Visual Studio\Boku_no_hero\Intro-Curta.mp3";
        private SoundPlayer _soundplayer;
        public Form2()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer("Intro-Curta.wav");
        }

        void clear()
        {
            textBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            pictureBox2.Image = null;

        }
        void resetar()
        {
            comboBox1.Text = "";
            label1.Visible = false;
            comboBox1.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            //combo

            label3.Visible = false;
            pictureBox2.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel7.Visible = false;
            panel5.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            //opcao

            label4.Visible = false;
            textBox1.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel6.Visible = false;
            panel13.Visible = false;
            //text

            label5.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            panel19.Visible = false;
            panel18.Visible = false;
            panel20.Visible = false;
            panel8.Visible = false;
            pictureBox3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.Visible = false;
            comboBox1.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel4.Visible = false;
            panel2.Visible = false;
            //combo

            label3.Visible = false;
            pictureBox2.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel7.Visible = false;
            panel5.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            //opcao

            label4.Visible = false;
            textBox1.Visible = false;
            panel15.Visible = false;
            panel14.Visible = false;
            panel6.Visible = false;
            panel13.Visible = false;
            //text

            label5.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            panel19.Visible = false;
            panel18.Visible = false;
            panel20.Visible = false;
            panel8.Visible = false;
            pictureBox3.Visible = false;
            //radio
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;

            pictureBox2.Visible = false;
            panel17.Visible = false;
            panel16.Visible = false;
            panel7.Visible = false;
            panel5.Visible = false;

            if (comboBox1.Text == "Personagens principais")
            {
                pictureBox3.Image = null;
                label5.Text = "Escolha o Personagem:";
                radioButton1.Text = "Izuku Midoriya";
                radioButton2.Text = "Katsuki Bakugo";
                radioButton3.Text = "Shoto Todoroki";
                label5.Visible = true;
                panel19.Visible = true;
                panel18.Visible = true;
                panel20.Visible = true;
                panel8.Visible = true;
                pictureBox3.Visible = true;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;


            }
            else if(comboBox1.Text == "Liga dos vilões")
            {
                pictureBox3.Image = null;
                label5.Text = "Escolha o Personagem:";
                radioButton1.Text = "All For One";
                radioButton2.Text = "Tomura Shigaraki";
                radioButton3.Text = "Dabi";
                radioButton4.Text = "Kurogiri";
                radioButton5.Text = "Twice";
                radioButton6.Text = "Himiko Toga";
                radioButton7.Text = "Moonfish";
                radioButton8.Text = "Magne";
                radioButton9.Text = "Spinner";
                radioButton10.Text = "Mr. Compress";
                radioButton11.Text = "Mustard";
                radioButton12.Text = "Muscular";
                label5.Visible = true;
                panel19.Visible = true;
                panel18.Visible = true;
                panel20.Visible = true;
                panel8.Visible = true;
                pictureBox3.Visible = true;

            }
            else if (comboBox1.Text == "Temporada 1")
            {
                clear();
                label3.Visible = true;
                pictureBox2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                pictureBox2.Visible = true;
                panel17.Visible = true;
                panel16.Visible = true;
                panel7.Visible = true;
                panel5.Visible = true;
                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;

            }
            else if (comboBox1.Text == "Temporada 2")
            {
                clear();
                label3.Visible = true;
                pictureBox2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                pictureBox2.Visible = true;
                panel17.Visible = true;
                panel16.Visible = true;
                panel7.Visible = true;
                panel5.Visible = true;
                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
            }
            else if (comboBox1.Text == "Temporada 3")
            {
                clear();
                label3.Visible = true;
                pictureBox2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                pictureBox2.Visible = true;
                panel17.Visible = true;
                panel16.Visible = true;
                panel7.Visible = true;
                panel5.Visible = true;
                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
            }
            else if (comboBox1.Text == "Temporada 4")
            {
                clear();
                label3.Visible = true;
                pictureBox2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                pictureBox2.Visible = true;
                panel17.Visible = true;
                panel16.Visible = true;
                panel7.Visible = true;
                panel5.Visible = true;
                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
            }
            else if (comboBox1.Text == "Temporada 5")
            {
                clear();
                label3.Visible = true;
                pictureBox2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                pictureBox2.Visible = true;
                panel17.Visible = true;
                panel16.Visible = true;
                panel7.Visible = true;
                panel5.Visible = true;
                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
            }
            else if (comboBox1.Text == " ")
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox1.Text == "Enrredo" && comboBox1.Text == "Temporada 1")
            {
                textBox1.Text = "Midoriya, mesmo sem poderes, sonha em se tornar um herói e para isto almeja entrar na melhor escola de super heróis do país o UA High School (a escola mais disputada do país).Midoriya, é fã incondicional de All Might(o herói número um e símbolo da paz). Além disso, nosso protagonista é aficionado por heróis no geral, acompanhando todos os atos heroicos e inclusive possuindo cadernos de anotações sobre características, poderes e ataques mais usados por cada um deles.";
                label4.Text = "Enrredo:";
                label4.Visible = true;
                textBox1.Visible = true;
                panel15.Visible = true;
                panel14.Visible = true;
                panel6.Visible = true;
                panel13.Visible = true;
            }
            else if(checkBox1.Checked && checkBox1.Text == "Enrredo" && comboBox1.Text == "Temporada 2")
            {
                textBox1.Text = "A segunda temporada começa imediatamente após os eventos da primeira. Para quem não lembra, a escola foi invadida pela união dos vilões e isso virou notícia no país inteiro.O clima não está dos melhores tanto na escola como no país que ficou abalado, pois sua maior escola de heróis foi invadida, aliás muito facilmente, mas o AllMight estava lá e conseguiu vencer os vilões.Na escola, todos ficaram com medo das repercussões que isso poderia causar mas o clima melhora rapidamente com o anúncio do Festival de Esportes.Diferente das outras escolas, o Festival de Esportes da UA é transmitido em rede nacional.Essa também é a chance dos alunos de mostrarem seus talentos, já que os alunos precisam realizar um “estágio” antes de se tornarem heróis e o festival é uma chance de convencer os melhores heróis a te “contratarem” como estagiários.";
                label4.Text = "Enrredo:";
                label4.Visible = true;
                textBox1.Visible = true;
                panel15.Visible = true;
                panel14.Visible = true;
                panel6.Visible = true;
                panel13.Visible = true;
            }
            else if(checkBox1.Checked && checkBox1.Text == "Enrredo" && comboBox1.Text == "Temporada 3")
            {
                textBox1.Text = "Já no segundo episódio da terceira temporada acompanhamos os alunos das salas 1-A e 1-B indo para um acampamento em conjunto. Algum tempo depois de entrarem no ônibus, este para em um lugar remoto para uma pausa e os alunos poderem ir ao banheiro.Quando os alunos da sala 1 - A saem do ônibus,são surpreendidos por duas mulheres vestidas gato e um criança. Elas são duas heroínas, facilmente reconhecidas por Midoriya, que formaram uma agência de super-heróis.Junto com elas está uma criança que fica somente observando e com cara de nervosa.Elas informam que eles tem 3 horas para chegar no acampamento distante e que nesse percurso enfrentarão várias dificuldades.";
                label4.Text = "Enrredo:";
                label4.Visible = true;
                textBox1.Visible = true;
                panel15.Visible = true;
                panel14.Visible = true;
                panel6.Visible = true;
                panel13.Visible = true;
            }
            else if (checkBox1.Checked && checkBox1.Text == "Enrredo" && comboBox1.Text == "Temporada 4")
            {
                textBox1.Text = "Overhaul, Kai Chisaki, capitão Yakuza do Shie Hassaikai, conhecidos como “Os 8 Preceitos da Morte”. Com ele, está um novo tipo de arma que possui balas que ao atingir alguém, a pessoa pode perder a individualidade. Assim, temos um arco inteiro que acompanha os estudantes da UA com seus estágios, enfoque a Midoriya, que aceita o estágio com o herói Night Eye, antigo parceiro de All Might.Nesse momento, também conhecemos Mirio Togata, estudante do terceiro ano da UA e que era o possível candidato para herdar os poderes de All Might. Ele também é estagiário de Night Eye.Também conhecemos seus parceiros e estudantes do 3º ano, Tamaki Amajiki e Hadou Nejire.Juntos, eles formam o “The Big 3”.";
                label4.Text = "Enrredo:";
                label4.Visible = true;
                textBox1.Visible = true;
                panel15.Visible = true;
                panel14.Visible = true;
                panel6.Visible = true;
                panel13.Visible = true;
            }
            else if (checkBox1.Checked && checkBox1.Text == "Enrredo" && comboBox1.Text == "Temporada 5")
            {
                textBox1.Text = "O primeiro episódio já inicia em um clima bem quente (rsrs)! Somos apresentados a finalização da batalha entre Endeavor e Hawks contra a nova raça de Nomus.Isso é uma questão bem forte nessa temporada, o planejamento para enfrentar esses inimigos praticamente invencíveis, e todo o terror que eles carregam.Batalhas titânicas são realizadas, e fortes emoções são transmitidas ao espectador!";
                label4.Text = "Enrredo:";
                label4.Visible = true;
                textBox1.Visible = true;
                panel15.Visible = true;
                panel14.Visible = true;
                panel6.Visible = true;
                panel13.Visible = true;
            }
            else if (checkBox1.Checked == false && checkBox1.Text == "Enrredo")
            {
                textBox1.Text= "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked && checkBox2.Text == "Logo" && comboBox1.Text== "Temporada 1")
            {
                pictureBox2.Image = Properties.Resources.logo_temp1;
                pictureBox2.Visible = true;
            }
            else if(checkBox2.Checked && checkBox2.Text == "Logo" && comboBox1.Text == "Temporada 2")
            {
                pictureBox2.Image = Properties.Resources.logo_temp2;
                pictureBox2.Visible = true;
            }
            else if (checkBox2.Checked && checkBox2.Text == "Logo" && comboBox1.Text == "Temporada 3")
            {
                pictureBox2.Image = Properties.Resources.logo_temp3;
                pictureBox2.Visible = true;
            }
            else if (checkBox2.Checked && checkBox2.Text == "Logo" && comboBox1.Text == "Temporada 4")
            {
                pictureBox2.Image = Properties.Resources.logo_temp4;
                pictureBox2.Visible = true;
            }
            else if (checkBox2.Checked && checkBox2.Text == "Logo" && comboBox1.Text == "Temporada 5")
            {
                pictureBox2.Image = Properties.Resources.logo_temp5;
                pictureBox2.Visible = true;
            }
            else if(checkBox2.Checked == false && checkBox2.Text == "Logo")
            {
                pictureBox2.Image = null;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (listBox1.SelectedIndex == 0)
            {
                resetar();
                label4.Text = "Sinopse:";
                textBox1.Text = "My Hero Academia conta a história de Izuku Midoriya ou Deku, um jovem que nasceu sem Indivualidade (poder) em um mundo em que 80% da população manifesta ao menos uma desde criança. O sonho do jovem de se tornar um herói, inspirado pelo herói nº 1, All Might, é massacrado pela descoberta. Prestes a adentrar o colegial, Midoriya tem um encontro com All Might, que o salva, mas ele acidentalmente mostra que está enfraquecendo.Em seguida, quando o herói vê a coragem do garoto ao se jogar no perigo para salvar o colega e rival, Bakugo, ele o aceita como pupilo, ajuda - o a treinar e, por fim, passa a Individualidade One For All para Deku. Gradualmente descobrindo os poderes e limites da Individualidade, Midoriya ingressa na turma 1 - A da U.A., um colégio especializado para treinar alunos que querem ser heróis.";

                label4.Visible = true;
                textBox1.Visible = true;
                panel15.Visible = true;
                panel14.Visible = true;
                panel6.Visible = true;
                panel13.Visible = true;

                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                label1.Visible = false;
                comboBox1.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel4.Visible = false;
                panel2.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;

            }
            else if(listBox1.SelectedIndex == 1)
            {
                

                resetar();
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Temporada 1");
                comboBox1.Items.Add("Temporada 2");
                comboBox1.Items.Add("Temporada 3");
                comboBox1.Items.Add("Temporada 4");
                comboBox1.Items.Add("Temporada 5");
                comboBox1.SelectedIndex = 0;
                checkBox1.Text = "Enrredo";
                checkBox2.Text = "Logo";

                label5.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;

                label1.Visible = true;
                comboBox1.Visible = true;
                panel9.Visible = true;
                panel10.Visible = true;
                panel4.Visible = true;
                panel2.Visible = true;

                label5.Visible = false;
                panel19.Visible = false;
                panel18.Visible = false;
                panel20.Visible = false;
                panel8.Visible = false;
                pictureBox3.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;

            }
            else if (listBox1.SelectedIndex == 2)
            {
                resetar();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Personagens principais");
                comboBox1.Items.Add("Liga dos vilões");
                checkBox1.Text = "Sobre";
                checkBox2.Text = "Poder";

                label1.Visible = true;
                comboBox1.Visible = true;
                panel9.Visible = true;
                panel10.Visible = true;
                panel4.Visible = true;
                panel2.Visible = true;

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked && radioButton1.Text == "Izuku Midoriya")
            {
                pictureBox3.Image = Properties.Resources.P_Deku;
            }
            else if(radioButton1.Checked && radioButton1.Text == "All For One")
            {
                pictureBox3.Image = Properties.Resources.V_allforone;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && radioButton2.Text == "Katsuki Bakugo")
            {
                pictureBox3.Image = Properties.Resources.P_bakugo;
            }
            else if (radioButton2.Checked && radioButton2.Text == "Tomura Shigaraki")
            {
                pictureBox3.Image = Properties.Resources.V_tomura;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked && radioButton3.Text == "Shoto Todoroki")
            {
                pictureBox3.Image = Properties.Resources.P_Shoto;
            }
            else if (radioButton3.Checked && radioButton3.Text == "Dabi")
            {
                pictureBox3.Image = Properties.Resources.V_dabi;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked && radioButton4.Text == "Kurogiri")
            {
                pictureBox3.Image = Properties.Resources.V_Kurogiri;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked && radioButton5.Text == "Twice")
            {
                pictureBox3.Image = Properties.Resources.V_twice;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked && radioButton6.Text == "Himiko Toga")
            {
                pictureBox3.Image = Properties.Resources.V_himiko;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked && radioButton7.Text == "Moonfish")
            {
                pictureBox3.Image = Properties.Resources.V_Moonfish;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked && radioButton8.Text == "Magne")
            {
                pictureBox3.Image = Properties.Resources.V_magne;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked && radioButton9.Text == "Spinner")
            {
                pictureBox3.Image = Properties.Resources.V_spinner;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked && radioButton10.Text == "Mr. Compress")
            {
                pictureBox3.Image = Properties.Resources.V_MrCompress;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked && radioButton11.Text == "Mustard")
            {
                pictureBox3.Image = Properties.Resources.V_mustard;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked && radioButton12.Text == "Muscular")
            {
                pictureBox3.Image = Properties.Resources.V_muscular;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que quer sair? :(", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)

            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nada 
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                checkBox3.Text = "Stop";
                _soundplayer.Play();
            }
            else
            {
                checkBox3.Text = "Play";
                _soundplayer.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
