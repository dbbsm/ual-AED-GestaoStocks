using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RUC__FERNANDO_TOMAS_DIOGO
{
    public partial class Form1 : Form
    {
        BinaryFormatter binForm = new BinaryFormatter();


        List<Computador_Portatil> ListaPortateis = new List<Computador_Portatil>();
        List<Impressora> ListaImpressoras = new List<Impressora>();
        List<fornecedor> ListaFornecedores = new List<fornecedor>();
        List<Departamento_requisitante> ListaDepartamentos = new List<Departamento_requisitante>();

        //declaraçao de variaveis
        int indimp = 0;//indice de impressoras
        int indport = 0;//indice de portateis
        int inddep = 0;//indice de departamentos
        int indforn = 0;//indice de fornecedores

        public Form1()
        {
            InitializeComponent();

            combomudaproduto.Items.Add("Impressoras");
            combomudaproduto.Items.Add("Portáteis");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se o ficheiro existir carrega o seu conteudo
            if (File.Exists("Impressoras.dat"))
            {
                FileStream ficheirotemporario = new FileStream("Impressoras.dat", FileMode.Open);

                Impressora[] tempimp = (Impressora[])binForm.Deserialize(ficheirotemporario);
                ListaImpressoras.Clear();
                foreach (Impressora imp in tempimp)
                {
                    ListaImpressoras.Add(imp);
                    indimp++;
                }
                ficheirotemporario.Close();
            }
            // Se o ficheiro existir carrega o seu conteudo
            if (File.Exists("Portateis.dat"))
            {
                FileStream ficheirotemporario = new FileStream("Portateis.dat", FileMode.Open);

                Computador_Portatil[] tempport = (Computador_Portatil[])binForm.Deserialize(ficheirotemporario);
                ListaPortateis.Clear();
                foreach (Computador_Portatil port in tempport)
                {
                    ListaPortateis.Add(port);
                    indport++;
                }
                ficheirotemporario.Close();
            }
            // Se o ficheiro existir carrega o seu conteudo
            if (File.Exists("Fornecedores.dat"))
            {
                FileStream ficheirotemporario = new FileStream("Fornecedores.dat", FileMode.Open);

                fornecedor[] tempforn = (fornecedor[])binForm.Deserialize(ficheirotemporario);
                ListaFornecedores.Clear();
                foreach (fornecedor forn in tempforn)
                {
                    ListaFornecedores.Add(forn);
                    indforn++;
                }
                ficheirotemporario.Close();
            }
            // Se o ficheiro existir carrega o seu conteudo
            if (File.Exists("Departamentos.dat"))
            {
                FileStream ficheirotemporario = new FileStream("Departamentos.dat", FileMode.Open);

                Departamento_requisitante[] tempdep = (Departamento_requisitante[])binForm.Deserialize(ficheirotemporario);
                ListaDepartamentos.Clear();
                foreach (Departamento_requisitante dep in tempdep)
                {
                    ListaDepartamentos.Add(dep);
                    inddep++;
                }
                ficheirotemporario.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lInfo_Click(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            //criar um novo portatil
            Computador_Portatil portatil = new Computador_Portatil();
            //Atribui a cada atributo a designaçao escrita nas caixas de texto
            portatil.Processador = textBox34.Text;
            portatil.Velocidade_GHz = Convert.ToDouble(textBox35.Text);
            portatil.Memoria_RAM = int.Parse(textBox60.Text);
            portatil.Memoria_cache = Convert.ToDouble(textBox58.Text);
            portatil.Disco_rigido = Convert.ToInt32(textBox59.Text);
            portatil.Velocidade_de_rotacao = int.Parse(textBox56.Text);
            portatil.Tamanho_de_ecran = Convert.ToDouble(textBox57.Text);
            portatil.Resolucao = textBox53.Text;
            portatil.Outras_caracteristicas_ecran = textBox54.Text;
            portatil.Sistema_operativo = textBox55.Text;
            portatil.Placa_grafica = textBox48.Text;
            portatil.Leitor_gravador = textBox49.Text;
            portatil.Portas_USB = int.Parse(textBox50.Text);
            portatil.Portas_video = textBox51.Text;
            portatil.Leitor_de_cartoes = textBox52.Text;
            portatil.Acessorios = textBox43.Text;
            portatil.Audio = textBox46.Text;
            portatil.Colunas = textBox47.Text;
            portatil.Bluetooth = textBox45.Text;
            portatil.Rede = textBox44.Text;
            portatil.Software = textBox42.Text;
            portatil.Dimensoespc = textBox41.Text;
            portatil.Pesopc = Convert.ToDouble(textBox40.Text);
            portatil.DesignacaoBase = textBox39.Text;
            portatil.Quantidadep = int.Parse(textBox38.Text);
            portatil.Descricaop = textBox37.Text;
            portatil.Fornecedorp = textBox36.Text;
            portatil.Stock_criticop = Convert.ToInt32(textBox78.Text);
            portatil.Unidade_de_quantidade = textBox79.Text;

            ListaPortateis.Add(portatil);//adicionar um portatil a lista de portateis

            indport++;//incrementar o indice de portateis mais um

            label47.Text = Convert.ToString(indport);//mostrar o indice de portateis
            //mostrar uma mensagem a avisar que o portatil foi criado com sucesso
            MessageBox.Show("O portátil: " + indport + " foi criado e adicionado a lista com sucesso!");

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            //cria uma nova impressora
            Impressora impressora = new Impressora();
            //atribui a cada atributo da impressora o respectivo valor
            impressora.Tipo = textBox11.Text;
            impressora.Tecnologia = textBox20.Text;
            impressora.Cor = textBox10.Text;
            impressora.Formatos_compativeis = textBox21.Text;
            impressora.Tipo_de_scanner = textBox23.Text;
            impressora.Funcao_fotocopiadora = textBox22.Text;
            impressora.Caracteristicas_impressao = textBox25.Text;
            impressora.Interfaces = textBox26.Text;
            impressora.Plataformas_compativeis = textBox24.Text;
            impressora.Pesoimp = double.Parse(textBox31.Text);
            impressora.Dimensoesimp = textBox33.Text;
            impressora.DesignacaoBase = textBox32.Text;
            impressora.Quantidadep = int.Parse(textBox30.Text);
            impressora.Unidade_de_quantidade = textBox29.Text;
            impressora.Descricaop= textBox28.Text;
            impressora.Fornecedorp = textBox27.Text;
            impressora.Stock_criticop = Convert.ToInt32(textBox80.Text);

            ListaImpressoras.Add(impressora);//adiciona a nova impressora a lista de impressoras

            indimp++;//incrementa uma unidade ao indice de impressoras
            //mostra uma mensagem a confirmar que a impressora foi criada e adicionada a lista
            MessageBox.Show("A impressora: " + indimp + " foi criado e adicionado a lista com sucesso!");
            //mostra o indice da impressora
            label48.Text = Convert.ToString(indimp);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            //percorrer todos os elementos da lista de portateis e mostrar os seus atributos
            for (int i = 0; i < ListaPortateis.Count; i++)
            {


                MessageBox.Show("Computador Portatil " + (i+1)+":"+ListaPortateis[i].Display());

            }

        }
        //mostrar lista de impressoras
        private void button3_Click(object sender, EventArgs e)
        {
            //percorrer todos os elementos da lista de impressoras e mostrar os atributos de cada elemento
            for (int j = 0; j < ListaImpressoras.Count; j++)
            {
                MessageBox.Show("Impressora " + (j + 1) + ":" +ListaImpressoras[j].Display());
            }
        }
        //criar um novo fornecedor
        private void button7_Click(object sender, EventArgs e)
        {
            //criar um novo fornecedor
            fornecedor Fornecedor = new fornecedor();
            //atribuir a cada atributo o seu respectivo valor
            Fornecedor.Nome_organizacao = textBox61.Text;
            Fornecedor.Morada = textBox69.Text;
            Fornecedor.Telefone = Convert.ToInt32(textBox68.Text);
            Fornecedor.Email = textBox66.Text;
            Fornecedor.Site = textBox67.Text;
            Fornecedor.Telemovel = Convert.ToInt32(textBox65.Text);
            Fornecedor.Pessoa_de_contacto = textBox62.Text;
            Fornecedor.Tipo_de_material = textBox64.Text;
            //adicionar o fornecedor a lista
            ListaFornecedores.Add(Fornecedor);
            //aumentar o indice dos fornecedores
            indforn++;
            //mostrar uma mensagem a confirmar que o fornecedor foi criado e adicionado a lista
            MessageBox.Show("O fornecedor: " + indforn + " foi criado e adicionado a lista com sucesso!");
            //mostrar o indice dos fornecedores
            label49.Text = Convert.ToString(indforn);
        }
        //cria um novo departamento
        private void button8_Click(object sender, EventArgs e)
        {
            //cria um novo departamento
            Departamento_requisitante Departamento = new Departamento_requisitante();
            //atribuir a cada atributo o seu respectivo valor
            Departamento.Nome_organizacao = textBox75.Text;
            Departamento.Morada = textBox63.Text;
            Departamento.Telefone = Convert.ToInt32(textBox70.Text);
            Departamento.Email = textBox72.Text;
            Departamento.Site = textBox71.Text;
            Departamento.Telemovel = Convert.ToInt32(textBox73.Text);
            Departamento.Pessoa_de_contacto = textBox74.Text;
            Departamento.Area_departamental = textBox76.Text;
            Departamento.Numeros_funcionarios = textBox77.Text;
            //adicionar o novo departamenti a lista
            ListaDepartamentos.Add(Departamento);
            //incrementa uma unidade ao indice de departamentos
            inddep++;
            //apresenta uma mensagem no ecra a confirmar que o departamento foi criado e adicionado a lista
            MessageBox.Show("O departamento: " + inddep + " foi criado e adicionado a lista com sucesso!");
            //mostra o indice do departamento na lista
            label50.Text = Convert.ToString(inddep);
        }
        //mostra todos os elementos presentes na lista de fornecedores
        private void button5_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < ListaFornecedores.Count; k++)
            {
                MessageBox.Show("Fornecedor " + (k + 1) + ":" + ListaFornecedores[k].Display());
            }
        }
        //mostra todos os elementos presentes na lista de departamentos e os respectivos atributos
        private void button6_Click(object sender, EventArgs e)
        {
            for (int w = 0; w < ListaDepartamentos.Count; w++)
            {
                MessageBox.Show("Departamento " + (w + 1) + ":" + ListaDepartamentos[w].Display());
            }
        }
        //funçao responsavel por limpar as caixas de texto dos atributos do portatil
        private void Limpaecrapc()
        {
            textBox34.Text =""; 
            textBox35.Text ="";
            textBox60.Text ="";
            textBox58.Text = "";
            textBox59.Text = "";
            textBox56.Text = "";
            textBox57.Text = "";
            textBox53.Text = "";
            textBox54.Text = "";
            textBox55.Text = "";
            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
            textBox43.Text = "";
            textBox46.Text = "";
            textBox47.Text = "";
            textBox45.Text = "";
            textBox44.Text = "";
            textBox42.Text = "";
            textBox41.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
            textBox37.Text = "";
            textBox36.Text = "";
            textBox78.Text = "";
            textBox79.Text = "";

            label47.Text = "";
        }
        //botao limpar do portatil
        private void Limpar_Click(object sender, System.EventArgs e)
        {
            Limpaecrapc();//chama a funçao limparpc
        }
        //funçao responsavel por limpar as caixas de texto dos atributos da impressora
        private void Limpaecraimp()
        {
            textBox11.Text = "";
            textBox20.Text = "";
            textBox10.Text = "";
            textBox21.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox24.Text = "";
            textBox31.Text = "";
            textBox33.Text = "";
            textBox32.Text = "";
            textBox30.Text = "";
            textBox29.Text = "";
            textBox28.Text = "";
            textBox27.Text = "";
            textBox80.Text = "";

            label48.Text = "";
        }
        //botao limpar da impressora
        private void button9_Click(object sender, System.EventArgs e)
        {
            Limpaecraimp();//chama a funçao limparimp
        }
        //funçao responsavel por limpar as caixas de texto dos atributos do fornecedor
        private void Limpaecraf()
        {
            textBox61.Text = "";
            textBox69.Text = "";
            textBox68.Text = "";
            textBox66.Text = "";
            textBox67.Text = "";
            textBox65.Text = "";
            textBox62.Text = "";
            textBox64.Text = "";

            label49.Text = "";
 
        }
        //botao limpar do fornecedor
        private void button10_Click(object sender, System.EventArgs e)
        {
            Limpaecraf();//chama a funçao limpaecraf
        }
        //funçao responsavel por limpar as caixas de texto dos atributos do departamento
        private void Limpaecrad()
        {
            textBox75.Text = "";
            textBox63.Text = "";
            textBox70.Text = "";
            textBox72.Text = "";
            textBox71.Text = "";
            textBox73.Text = "";
            textBox74.Text = "";
            textBox76.Text = "";
            textBox77.Text = "";

            label50.Text = "";

            

        }
        //botao limpar do departamento
        private void button11_Click(object sender, System.EventArgs e)
        {
            Limpaecrad();//chama a funçao limpaecrad
        }

        private void tabPage1_Click(object sender, System.EventArgs e)
        {
            

            
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            if (indport == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (indport + 1 <= ListaPortateis.Count)
                {
                    Computador_Portatil portatil = new Computador_Portatil();
                    indport++;
                    portatil = ListaPortateis[indport - 1];

                    textBox34.Text = portatil.Processador;
                    textBox35.Text = Convert.ToString(portatil.Velocidade_GHz);
                    textBox60.Text = Convert.ToString(portatil.Memoria_RAM);
                    textBox58.Text = Convert.ToString(portatil.Memoria_cache);
                    textBox59.Text = Convert.ToString(portatil.Disco_rigido);
                    textBox56.Text = Convert.ToString(portatil.Velocidade_de_rotacao);
                    textBox57.Text = Convert.ToString(portatil.Tamanho_de_ecran);
                    textBox53.Text = portatil.Resolucao;
                    textBox54.Text = portatil.Outras_caracteristicas_ecran;
                    textBox55.Text = portatil.Sistema_operativo;
                    textBox48.Text = portatil.Placa_grafica;
                    textBox49.Text = portatil.Leitor_gravador;
                    textBox50.Text = Convert.ToString(portatil.Portas_USB);
                    textBox51.Text = portatil.Portas_video;
                    textBox52.Text = portatil.Leitor_de_cartoes;
                    textBox43.Text = portatil.Acessorios;
                    textBox46.Text = portatil.Audio;
                    textBox47.Text = portatil.Colunas;
                    textBox45.Text = portatil.Bluetooth;
                    textBox44.Text = portatil.Rede;
                    textBox42.Text = portatil.Software;
                    textBox41.Text = portatil.Dimensoespc;
                    textBox40.Text = Convert.ToString(portatil.Pesopc);
                    textBox39.Text = portatil.DesignacaoBase;
                    textBox38.Text = Convert.ToString(portatil.Quantidadep);
                    textBox37.Text = portatil.Descricaopc;
                    textBox36.Text = portatil.Fornecedorp;
                    textBox78.Text = Convert.ToString(portatil.Stock_criticop);
                    textBox79.Text = portatil.Unidade_de_quantidade;

                    label47.Text = Convert.ToString(indport);
                }

                else
                {
                   

                    Computador_Portatil portatil = new Computador_Portatil();
                    
                    portatil = ListaPortateis[indport - 1];

                    textBox34.Text = portatil.Processador;
                    textBox35.Text = Convert.ToString(portatil.Velocidade_GHz);
                    textBox60.Text = Convert.ToString(portatil.Memoria_RAM);
                    textBox58.Text = Convert.ToString(portatil.Memoria_cache);
                    textBox59.Text = Convert.ToString(portatil.Disco_rigido);
                    textBox56.Text = Convert.ToString(portatil.Velocidade_de_rotacao);
                    textBox57.Text = Convert.ToString(portatil.Tamanho_de_ecran);
                    textBox53.Text = portatil.Resolucao;
                    textBox54.Text = portatil.Outras_caracteristicas_ecran;
                    textBox55.Text = portatil.Sistema_operativo;
                    textBox48.Text = portatil.Placa_grafica;
                    textBox49.Text = portatil.Leitor_gravador;
                    textBox50.Text = Convert.ToString(portatil.Portas_USB);
                    textBox51.Text = portatil.Portas_video;
                    textBox52.Text = portatil.Leitor_de_cartoes;
                    textBox43.Text = portatil.Acessorios;
                    textBox46.Text = portatil.Audio;
                    textBox47.Text = portatil.Colunas;
                    textBox45.Text = portatil.Bluetooth;
                    textBox44.Text = portatil.Rede;
                    textBox42.Text = portatil.Software;
                    textBox41.Text = portatil.Dimensoespc;
                    textBox40.Text = Convert.ToString(portatil.Pesopc);
                    textBox39.Text = portatil.DesignacaoBase;
                    textBox38.Text = Convert.ToString(portatil.Quantidadep);
                    textBox37.Text = portatil.Descricaopc;
                    textBox36.Text = portatil.Fornecedorp;

                    label47.Text = Convert.ToString(indport);

                    MessageBox.Show("Já está no último elemento desta lista");
                }
            }
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            if (indport == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (indport - 1 > 0)
                {
                    Computador_Portatil portatil = new Computador_Portatil();

                    indport--;
                    portatil = ListaPortateis[indport - 1];

                    textBox34.Text = portatil.Processador;
                    textBox35.Text = Convert.ToString(portatil.Velocidade_GHz);
                    textBox60.Text = Convert.ToString(portatil.Memoria_RAM);
                    textBox58.Text = Convert.ToString(portatil.Memoria_cache);
                    textBox59.Text = Convert.ToString(portatil.Disco_rigido);
                    textBox56.Text = Convert.ToString(portatil.Velocidade_de_rotacao);
                    textBox57.Text = Convert.ToString(portatil.Tamanho_de_ecran);
                    textBox53.Text = portatil.Resolucao;
                    textBox54.Text = portatil.Outras_caracteristicas_ecran;
                    textBox55.Text = portatil.Sistema_operativo;
                    textBox48.Text = portatil.Placa_grafica;
                    textBox49.Text = portatil.Leitor_gravador;
                    textBox50.Text = Convert.ToString(portatil.Portas_USB);
                    textBox51.Text = portatil.Portas_video;
                    textBox52.Text = portatil.Leitor_de_cartoes;
                    textBox43.Text = portatil.Acessorios;
                    textBox46.Text = portatil.Audio;
                    textBox47.Text = portatil.Colunas;
                    textBox45.Text = portatil.Bluetooth;
                    textBox44.Text = portatil.Rede;
                    textBox42.Text = portatil.Software;
                    textBox41.Text = portatil.Dimensoespc;
                    textBox40.Text = Convert.ToString(portatil.Pesopc);
                    textBox39.Text = portatil.DesignacaoBase;
                    textBox38.Text = Convert.ToString(portatil.Quantidadep);
                    textBox37.Text = portatil.Descricaopc;
                    textBox36.Text = portatil.Fornecedorp;

                    textBox78.Text= Convert.ToString(portatil.Stock_criticop);
                    textBox79.Text = portatil.Unidade_de_quantidade;

                    label47.Text = Convert.ToString(indport);
                }

                else
                {
                    
                    Computador_Portatil portatil = new Computador_Portatil();
                    portatil = ListaPortateis[indport - 1];
                    textBox34.Text = portatil.Processador;
                    textBox35.Text = Convert.ToString(portatil.Velocidade_GHz);
                    textBox60.Text = Convert.ToString(portatil.Memoria_RAM);
                    textBox58.Text = Convert.ToString(portatil.Memoria_cache);
                    textBox59.Text = Convert.ToString(portatil.Disco_rigido);
                    textBox56.Text = Convert.ToString(portatil.Velocidade_de_rotacao);
                    textBox57.Text = Convert.ToString(portatil.Tamanho_de_ecran);
                    textBox53.Text = portatil.Resolucao;
                    textBox54.Text = portatil.Outras_caracteristicas_ecran;
                    textBox55.Text = portatil.Sistema_operativo;
                    textBox48.Text = portatil.Placa_grafica;
                    textBox49.Text = portatil.Leitor_gravador;
                    textBox50.Text = Convert.ToString(portatil.Portas_USB);
                    textBox51.Text = portatil.Portas_video;
                    textBox52.Text = portatil.Leitor_de_cartoes;
                    textBox43.Text = portatil.Acessorios;
                    textBox46.Text = portatil.Audio;
                    textBox47.Text = portatil.Colunas;
                    textBox45.Text = portatil.Bluetooth;
                    textBox44.Text = portatil.Rede;
                    textBox42.Text = portatil.Software;
                    textBox41.Text = portatil.Dimensoespc;
                    textBox40.Text = Convert.ToString(portatil.Pesopc);
                    textBox39.Text = portatil.DesignacaoBase;
                    textBox38.Text = Convert.ToString(portatil.Quantidadep);
                    textBox37.Text = portatil.Descricaopc;
                    textBox36.Text = portatil.Fornecedorp;

                    label47.Text = Convert.ToString(indport);
                    MessageBox.Show("Já está no primeiro elemento desta lista");
                }
            }
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            if (indport == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para alterar!");
            }
            else
            {
                Computador_Portatil portatil = new Computador_Portatil();

                portatil = ListaPortateis[indport - 1];

                portatil.Processador = textBox34.Text;
                portatil.Velocidade_GHz = Convert.ToDouble(textBox35.Text);
                portatil.Memoria_RAM = int.Parse(textBox60.Text);
                portatil.Memoria_cache = Convert.ToDouble(textBox58.Text);
                portatil.Disco_rigido = Convert.ToInt32(textBox59.Text);
                portatil.Velocidade_de_rotacao = int.Parse(textBox56.Text);
                portatil.Tamanho_de_ecran = Convert.ToDouble(textBox57.Text);
                portatil.Resolucao = textBox53.Text;
                portatil.Outras_caracteristicas_ecran = textBox54.Text;
                portatil.Sistema_operativo = textBox55.Text;
                portatil.Placa_grafica = textBox48.Text;
                portatil.Leitor_gravador = textBox49.Text;
                portatil.Portas_USB = int.Parse(textBox50.Text);
                portatil.Portas_video = textBox51.Text;
                portatil.Leitor_de_cartoes = textBox52.Text;
                portatil.Acessorios = textBox43.Text;
                portatil.Audio = textBox46.Text;
                portatil.Colunas = textBox47.Text;
                portatil.Bluetooth = textBox45.Text;
                portatil.Rede = textBox44.Text;
                portatil.Software = textBox42.Text;
                portatil.Dimensoespc = textBox41.Text;
                portatil.Pesopc = Convert.ToDouble(textBox40.Text);
                portatil.DesignacaoBase = textBox39.Text;
                portatil.Quantidadep = int.Parse(textBox38.Text);
                portatil.Descricaopc = textBox37.Text;
                portatil.Fornecedorp = textBox36.Text;
                portatil.Stock_criticop = Convert.ToInt32(textBox78.Text);
                portatil.Unidade_de_quantidade = textBox79.Text;
                MessageBox.Show("O portátil: " + indport + " foi alterada com sucesso!");
            }

        }

        private void Alterarimp_Click(object sender, System.EventArgs e)
        {
            if (indimp == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para alterar!");
            }
            else
            {
                Impressora impressora = new Impressora();
                impressora = ListaImpressoras[indimp - 1];

                impressora.Tipo = textBox11.Text;
                impressora.Tecnologia = textBox20.Text;
                impressora.Cor = textBox10.Text;
                impressora.Formatos_compativeis = textBox21.Text;
                impressora.Tipo_de_scanner = textBox23.Text;
                impressora.Funcao_fotocopiadora = textBox22.Text;
                impressora.Caracteristicas_impressao = textBox25.Text;
                impressora.Interfaces = textBox26.Text;
                impressora.Plataformas_compativeis = textBox24.Text;
                impressora.Pesoimp = double.Parse(textBox31.Text);
                impressora.Dimensoesimp = textBox33.Text;
                impressora.DesignacaoBase = textBox32.Text;
                impressora.Quantidadep = int.Parse(textBox30.Text);
                impressora.Unidade_de_quantidade = textBox29.Text;
                impressora.Descricaop = textBox28.Text;
                impressora.Fornecedorp = textBox27.Text;
                impressora.Stock_criticop = Convert.ToInt32(textBox80.Text);

                MessageBox.Show("A impressora: " + indimp + " foi alterada com sucesso!");
            }
        }

        private void Nextimp_Click(object sender, System.EventArgs e)
        {
            if (indimp == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (indimp + 1 <= ListaImpressoras.Count)
                {
                    Impressora impressora = new Impressora();
                    indimp++;
                    impressora = ListaImpressoras[indimp - 1];

                    textBox11.Text = impressora.Tipo;
                    textBox20.Text = impressora.Tecnologia;
                    textBox10.Text = impressora.Cor;
                    textBox21.Text = impressora.Formatos_compativeis;
                    textBox23.Text = impressora.Tipo_de_scanner;
                    textBox22.Text = impressora.Funcao_fotocopiadora;
                    textBox25.Text = impressora.Caracteristicas_impressao;
                    textBox26.Text = impressora.Interfaces;
                    textBox24.Text = impressora.Plataformas_compativeis;
                    textBox31.Text = Convert.ToString(impressora.Pesoimp);
                    textBox33.Text = impressora.Dimensoesimp;
                    textBox32.Text = impressora.DesignacaoBase;
                    textBox30.Text = Convert.ToString(impressora.Quantidadep);
                    textBox29.Text = impressora.Unidade_de_quantidade;
                    textBox28.Text = impressora.Descricaop;
                    textBox27.Text = impressora.Fornecedorp;
                    textBox80.Text = Convert.ToString(impressora.Stock_criticop);

                    label48.Text = Convert.ToString(indimp);
                }

                else
                {
                    

                    Impressora impressora = new Impressora();
                    impressora = ListaImpressoras[indimp - 1];

                    textBox11.Text = impressora.Tipo;
                    textBox20.Text = impressora.Tecnologia;
                    textBox10.Text = impressora.Cor;
                    textBox21.Text = impressora.Formatos_compativeis;
                    textBox23.Text = impressora.Tipo_de_scanner;
                    textBox22.Text = impressora.Funcao_fotocopiadora;
                    textBox25.Text = impressora.Caracteristicas_impressao;
                    textBox26.Text = impressora.Interfaces;
                    textBox24.Text = impressora.Plataformas_compativeis;
                    textBox31.Text = Convert.ToString(impressora.Pesoimp);
                    textBox33.Text = impressora.Dimensoesimp;
                    textBox32.Text = impressora.DesignacaoBase;
                    textBox30.Text = Convert.ToString(impressora.Quantidadep);
                    textBox29.Text = impressora.Unidade_de_quantidade;
                    textBox28.Text = impressora.Descricaop;
                    textBox27.Text = impressora.Fornecedorp;

                    label48.Text = Convert.ToString(indimp);
                    MessageBox.Show("Já está no último elemento desta lista");
                }
            }

        }

        private void Previousimp_Click(object sender, System.EventArgs e)
        {
            if (indimp == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (indimp - 1 > 0)
                {
                    Impressora impressora = new Impressora();

                    indimp--;
                    impressora = ListaImpressoras[indimp - 1];

                    textBox11.Text = impressora.Tipo;
                    textBox20.Text = impressora.Tecnologia;
                    textBox10.Text = impressora.Cor;
                    textBox21.Text = impressora.Formatos_compativeis;
                    textBox23.Text = impressora.Tipo_de_scanner;
                    textBox22.Text = impressora.Funcao_fotocopiadora;
                    textBox25.Text = impressora.Caracteristicas_impressao;
                    textBox26.Text = impressora.Interfaces;
                    textBox24.Text = impressora.Plataformas_compativeis;
                    textBox31.Text = Convert.ToString(impressora.Pesoimp);
                    textBox33.Text = impressora.Dimensoesimp;
                    textBox32.Text = impressora.DesignacaoBase;
                    textBox30.Text = Convert.ToString(impressora.Quantidadep);
                    textBox29.Text = impressora.Unidade_de_quantidade;
                    textBox28.Text = impressora.Descricaop;
                    textBox27.Text = impressora.Fornecedorp;
                    textBox80.Text = Convert.ToString(impressora.Stock_criticop);

                    label48.Text = Convert.ToString(indimp);

                }
                else
                {
                    

                    Impressora impressora = new Impressora();

                    impressora = ListaImpressoras[indimp - 1];

                    textBox11.Text = impressora.Tipo;
                    textBox20.Text = impressora.Tecnologia;
                    textBox10.Text = impressora.Cor;
                    textBox21.Text = impressora.Formatos_compativeis;
                    textBox23.Text = impressora.Tipo_de_scanner;
                    textBox22.Text = impressora.Funcao_fotocopiadora;
                    textBox25.Text = impressora.Caracteristicas_impressao;
                    textBox26.Text = impressora.Interfaces;
                    textBox24.Text = impressora.Plataformas_compativeis;
                    textBox31.Text = Convert.ToString(impressora.Pesoimp);
                    textBox33.Text = impressora.Dimensoesimp;
                    textBox32.Text = impressora.DesignacaoBase;
                    textBox30.Text = Convert.ToString(impressora.Quantidadep);
                    textBox29.Text = impressora.Unidade_de_quantidade;
                    textBox28.Text = impressora.Descricaop;
                    textBox27.Text = impressora.Fornecedorp;

                    label48.Text = Convert.ToString(indimp);
                    MessageBox.Show("Já está no primeiro elemento desta lista");
                }
            }
        }

        private void alterarforn_Click(object sender, System.EventArgs e)
        {
            if (indforn == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para alterar!");
            }
            else
            {
                fornecedor Fornecedor = new fornecedor();
                Fornecedor = ListaFornecedores[indforn - 1];

                Fornecedor.Nome_organizacao = textBox61.Text;
                Fornecedor.Morada = textBox69.Text;
                Fornecedor.Telefone = Convert.ToInt32(textBox68.Text);
                Fornecedor.Email = textBox66.Text;
                Fornecedor.Site = textBox67.Text;
                Fornecedor.Telemovel = Convert.ToInt32(textBox65.Text);
                Fornecedor.Pessoa_de_contacto = textBox62.Text;
                Fornecedor.Tipo_de_material = textBox64.Text;

                MessageBox.Show("O fornecedor: " + indforn + " foi alterado com sucesso!");
            }
        }

        private void Nextforn_Click(object sender, System.EventArgs e)
        {
            if (indforn == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (indforn + 1 <= ListaFornecedores.Count)
                {
                    fornecedor Fornecedor = new fornecedor();
                    indforn++;
                    Fornecedor = ListaFornecedores[indforn - 1];

                    textBox61.Text = Fornecedor.Nome_organizacao;
                    textBox69.Text = Fornecedor.Morada;
                    textBox68.Text = Convert.ToString(Fornecedor.Telefone);
                    textBox66.Text = Fornecedor.Email;
                    textBox67.Text = Fornecedor.Site;
                    textBox65.Text = Convert.ToString(Fornecedor.Telemovel);
                    textBox62.Text = Fornecedor.Pessoa_de_contacto;
                    textBox64.Text = Fornecedor.Tipo_de_material;

                    label49.Text = Convert.ToString(indforn);
                }

                else
                {
                    

                    fornecedor Fornecedor = new fornecedor();
                    Fornecedor = ListaFornecedores[indforn - 1];

                    textBox61.Text = Fornecedor.Nome_organizacao;
                    textBox69.Text = Fornecedor.Morada;
                    textBox68.Text = Convert.ToString(Fornecedor.Telefone);
                    textBox66.Text = Fornecedor.Email;
                    textBox67.Text = Fornecedor.Site;
                    textBox65.Text = Convert.ToString(Fornecedor.Telemovel);
                    textBox62.Text = Fornecedor.Pessoa_de_contacto;
                    textBox64.Text = Fornecedor.Tipo_de_material;

                    label49.Text = Convert.ToString(indforn);
                    MessageBox.Show("Já está no último elemento desta lista");
                }
            }
        }

        private void Previousforn_Click(object sender, System.EventArgs e)
        {
            if (indforn == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (indforn - 1 > 0)
                {
                    fornecedor Fornecedor = new fornecedor();

                    indforn--;
                    Fornecedor = ListaFornecedores[indforn - 1];

                    textBox61.Text = Fornecedor.Nome_organizacao;
                    textBox69.Text = Fornecedor.Morada;
                    textBox68.Text = Convert.ToString(Fornecedor.Telefone);
                    textBox66.Text = Fornecedor.Email;
                    textBox67.Text = Fornecedor.Site;
                    textBox65.Text = Convert.ToString(Fornecedor.Telemovel);
                    textBox62.Text = Fornecedor.Pessoa_de_contacto;
                    textBox64.Text = Fornecedor.Tipo_de_material;

                    label49.Text = Convert.ToString(indforn);

                }
                else
                {
                    

                    fornecedor Fornecedor = new fornecedor();

                    Fornecedor = ListaFornecedores[indforn - 1];

                    textBox61.Text = Fornecedor.Nome_organizacao;
                    textBox69.Text = Fornecedor.Morada;
                    textBox68.Text = Convert.ToString(Fornecedor.Telefone);
                    textBox66.Text = Fornecedor.Email;
                    textBox67.Text = Fornecedor.Site;
                    textBox65.Text = Convert.ToString(Fornecedor.Telemovel);
                    textBox62.Text = Fornecedor.Pessoa_de_contacto;
                    textBox64.Text = Fornecedor.Tipo_de_material;

                    label49.Text = Convert.ToString(indforn);
                    MessageBox.Show("Já está no primeiro elemento desta lista");
                }
            }
        }

        private void Alterardep_Click(object sender, System.EventArgs e)
        {
            if (inddep == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para alterar!");
            }
            else
            {
                Departamento_requisitante Departamento = new Departamento_requisitante();
                Departamento = ListaDepartamentos[inddep - 1];

                Departamento.Nome_organizacao = textBox75.Text;
                Departamento.Morada = textBox63.Text;
                Departamento.Telefone = Convert.ToInt32(textBox70.Text);
                Departamento.Email = textBox72.Text;
                Departamento.Site = textBox71.Text;
                Departamento.Telemovel = Convert.ToInt32(textBox73.Text);
                Departamento.Pessoa_de_contacto = textBox74.Text;
                Departamento.Area_departamental = textBox76.Text;
                Departamento.Numeros_funcionarios = textBox77.Text;

                MessageBox.Show("O departamento: " + inddep + " foi alterado com sucesso!");
            }

        }

        private void Previousdep_Click(object sender, System.EventArgs e)
        {
            if (inddep == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (inddep - 1 > 0)
                {
                    Departamento_requisitante Departamento = new Departamento_requisitante();

                    inddep--;
                    Departamento = ListaDepartamentos[inddep - 1];

                    textBox75.Text = Departamento.Nome_organizacao;
                    textBox63.Text = Departamento.Morada;
                    textBox70.Text = Convert.ToString(Departamento.Telefone);
                    textBox72.Text = Departamento.Email;
                    textBox71.Text = Departamento.Site;
                    textBox73.Text = Convert.ToString(Departamento.Telemovel);
                    textBox74.Text = Departamento.Pessoa_de_contacto;
                    textBox76.Text = Departamento.Area_departamental;
                    textBox77.Text = Departamento.Numeros_funcionarios;

                    label50.Text = Convert.ToString(inddep);

                }
                else
                {
                    

                    Departamento_requisitante Departamento = new Departamento_requisitante();
                    Departamento = ListaDepartamentos[inddep - 1];

                    textBox75.Text = Departamento.Nome_organizacao;
                    textBox63.Text = Departamento.Morada;
                    textBox70.Text = Convert.ToString(Departamento.Telefone);
                    textBox72.Text = Departamento.Email;
                    textBox71.Text = Departamento.Site;
                    textBox73.Text = Convert.ToString(Departamento.Telemovel);
                    textBox74.Text = Departamento.Pessoa_de_contacto;
                    textBox76.Text = Departamento.Area_departamental;
                    textBox77.Text = Departamento.Numeros_funcionarios;

                    label50.Text = Convert.ToString(inddep);
                    MessageBox.Show("Já está no primeiro elemento desta lista");
                }
            }
        }

        private void Nextdep_Click(object sender, System.EventArgs e)
        {
            if (inddep == 0)
            {
                MessageBox.Show("Ainda nao introduzio nenhum elemento!");
            }

            else
            {
                if (inddep + 1 <= ListaDepartamentos.Count)
                {
                    Departamento_requisitante Departamento = new Departamento_requisitante();
                    inddep++;
                    Departamento = ListaDepartamentos[inddep - 1];

                    textBox75.Text = Departamento.Nome_organizacao;
                    textBox63.Text = Departamento.Morada;
                    textBox70.Text = Convert.ToString(Departamento.Telefone);
                    textBox72.Text = Departamento.Email;
                    textBox71.Text = Departamento.Site;
                    textBox73.Text = Convert.ToString(Departamento.Telemovel);
                    textBox74.Text = Departamento.Pessoa_de_contacto;
                    textBox76.Text = Departamento.Area_departamental;
                    textBox77.Text = Departamento.Numeros_funcionarios;

                    label50.Text = Convert.ToString(inddep);
                }

                else
                {
                    

                    Departamento_requisitante Departamento = new Departamento_requisitante();
                    Departamento = ListaDepartamentos[inddep - 1];

                    textBox75.Text = Departamento.Nome_organizacao;
                    textBox63.Text = Departamento.Morada;
                    textBox70.Text = Convert.ToString(Departamento.Telefone);
                    textBox72.Text = Departamento.Email;
                    textBox71.Text = Departamento.Site;
                    textBox73.Text = Convert.ToString(Departamento.Telemovel);
                    textBox74.Text = Departamento.Pessoa_de_contacto;
                    textBox76.Text = Departamento.Area_departamental;
                    textBox77.Text = Departamento.Numeros_funcionarios;

                    label50.Text = Convert.ToString(inddep);
                    MessageBox.Show("Já está no último elemento desta lista");
                }
            }

        }

        private void ApagarPort_Click(object sender, System.EventArgs e)
        {
            if (indport == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para apagar!");
            }
            else
            {
                Computador_Portatil portatil = new Computador_Portatil();
                portatil.Processador = textBox34.Text;
                portatil.Velocidade_GHz = Convert.ToDouble(textBox35.Text);
                portatil.Memoria_RAM = int.Parse(textBox60.Text);
                portatil.Memoria_cache = Convert.ToDouble(textBox58.Text);
                portatil.Disco_rigido = Convert.ToInt32(textBox59.Text);
                portatil.Velocidade_de_rotacao = int.Parse(textBox56.Text);
                portatil.Tamanho_de_ecran = Convert.ToDouble(textBox57.Text);
                portatil.Resolucao = textBox53.Text;
                portatil.Outras_caracteristicas_ecran = textBox54.Text;
                portatil.Sistema_operativo = textBox55.Text;
                portatil.Placa_grafica = textBox48.Text;
                portatil.Leitor_gravador = textBox49.Text;
                portatil.Portas_USB = int.Parse(textBox50.Text);
                portatil.Portas_video = textBox51.Text;
                portatil.Leitor_de_cartoes = textBox52.Text;
                portatil.Acessorios = textBox43.Text;
                portatil.Audio = textBox46.Text;
                portatil.Colunas = textBox47.Text;
                portatil.Bluetooth = textBox45.Text;
                portatil.Rede = textBox44.Text;
                portatil.Software = textBox42.Text;
                portatil.Dimensoespc = textBox41.Text;
                portatil.Pesopc = Convert.ToDouble(textBox40.Text);
                portatil.DesignacaoBase = textBox39.Text;
                portatil.Quantidadep = int.Parse(textBox38.Text);
                portatil.Descricaopc = textBox37.Text;
                portatil.Fornecedorp = textBox36.Text;
                portatil.Stock_criticop = Convert.ToInt32(textBox78.Text);
                portatil.Unidade_de_quantidade = textBox79.Text;

                ListaPortateis.RemoveAt(indport - 1);
                

                MessageBox.Show("O portatil foi removido da lista com sucesso!");

                Limpaecrapc();
            }
        }

        private void Apagarimp_Click(object sender, System.EventArgs e)
        {
            if (indimp == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para apagar!");
            }
            else
            {
                Impressora impressora = new Impressora();

                impressora.Tipo = textBox11.Text;
                impressora.Tecnologia = textBox20.Text;
                impressora.Cor = textBox10.Text;
                impressora.Formatos_compativeis = textBox21.Text;
                impressora.Tipo_de_scanner = textBox23.Text;
                impressora.Funcao_fotocopiadora = textBox22.Text;
                impressora.Caracteristicas_impressao = textBox25.Text;
                impressora.Interfaces = textBox26.Text;
                impressora.Plataformas_compativeis = textBox24.Text;
                impressora.Pesoimp = double.Parse(textBox31.Text);
                impressora.Dimensoesimp = textBox33.Text;
                impressora.DesignacaoBase = textBox32.Text;
                impressora.Quantidadep = int.Parse(textBox30.Text);
                impressora.Unidade_de_quantidade = textBox29.Text;
                impressora.Descricaop = textBox28.Text;
                impressora.Fornecedorp = textBox27.Text;
                impressora.Stock_criticop = Convert.ToInt32(textBox80.Text);

                ListaImpressoras.RemoveAt(indimp - 1);

                

                MessageBox.Show("A impressora foi removida da lista com sucesso!");

                Limpaecraimp();
            }
        }

        private void Apagarforn_Click(object sender, System.EventArgs e)
        {
            if (indforn == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para apagar!");
            }
            else
            {
                fornecedor Fornecedor = new fornecedor();

                Fornecedor.Nome_organizacao = textBox61.Text;
                Fornecedor.Morada = textBox69.Text;
                Fornecedor.Telefone = Convert.ToInt32(textBox68.Text);
                Fornecedor.Email = textBox66.Text;
                Fornecedor.Site = textBox67.Text;
                Fornecedor.Telemovel = Convert.ToInt32(textBox65.Text);
                Fornecedor.Pessoa_de_contacto = textBox62.Text;
                Fornecedor.Tipo_de_material = textBox64.Text;

                ListaFornecedores.RemoveAt(indforn - 1);

                

                MessageBox.Show("O fornecedor foi removido da lista com sucesso!");

                Limpaecraf();
            }
        }

        private void Apagardep_Click(object sender, System.EventArgs e)
        {
            if (inddep == 0)
            {
                MessageBox.Show("Nao tem nenhum elemento para apagar!");
            }
            else
            {
                Departamento_requisitante Departamento = new Departamento_requisitante();

                Departamento.Nome_organizacao = textBox75.Text;
                Departamento.Morada = textBox63.Text;
                Departamento.Telefone = Convert.ToInt32(textBox70.Text);
                Departamento.Email = textBox72.Text;
                Departamento.Site = textBox71.Text;
                Departamento.Telemovel = Convert.ToInt32(textBox73.Text);
                Departamento.Pessoa_de_contacto = textBox74.Text;
                Departamento.Area_departamental = textBox76.Text;
                Departamento.Numeros_funcionarios = textBox77.Text;

                ListaDepartamentos.RemoveAt(inddep - 1);

                

                MessageBox.Show("O departamento foi removido da lista com sucesso!");

                Limpaecrad();
            }
        }

        private void label47_Click(object sender, System.EventArgs e)
        {

        }

        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Escrever Binarios
            //se existir impressoras para escrever ele escreve
            if(ListaImpressoras.Count>0)
            {
                FileStream ficheiroimp = new FileStream("Impressoras.dat",FileMode.Create);
                Impressora[] imp = new Impressora[ListaImpressoras.Count];

                int q = 0;
                foreach(Impressora impressora in ListaImpressoras)
                {
                    imp[q] = impressora;
                    q++;
                }
                binForm.Serialize(ficheiroimp, imp);
                ficheiroimp.Close();
            }
            //se existir elementos na lista de portateis ele escreve
            if(ListaPortateis.Count > 0)
            {
                FileStream ficheiropc = new FileStream("Portateis.dat", FileMode.Create);
                Computador_Portatil[] port = new Computador_Portatil[ListaPortateis.Count];

                int i = 0;
                foreach (Computador_Portatil portatil in ListaPortateis)
                {
                    port[i] = portatil;
                    i++;
                }
                binForm.Serialize(ficheiropc, port);
                ficheiropc.Close();
            }
            //se existirem fornecedores na lista ele escreve
            if (ListaFornecedores.Count > 0)
            {
                FileStream ficheiroforn = new FileStream("Fornecedores.dat", FileMode.Create);
                fornecedor[] forn = new fornecedor[ListaFornecedores.Count];

                int i = 0;
                foreach (fornecedor fornecedor in ListaFornecedores)
                {
                    forn[i] = fornecedor;
                    i++;
                }
                binForm.Serialize(ficheiroforn, forn);
                ficheiroforn.Close();
            }
            //se existirem elementos na lista dos departamentos ele escreve
            if (ListaDepartamentos.Count > 0)
            {
                FileStream ficheirodep = new FileStream("Departamentos.dat", FileMode.Create);
                Departamento_requisitante[] dep = new Departamento_requisitante[ListaDepartamentos.Count];

                int i = 0;
                foreach (Departamento_requisitante departamento in ListaDepartamentos)
                {
                    dep[i] = departamento;
                    i++;
                }
                binForm.Serialize(ficheirodep, dep);
                ficheirodep.Close();
            }
           
            

            StreamWriter writerpc = new StreamWriter("computadores_portateis.txt");

            writerpc.WriteLine("** Computadores **");
            writerpc.WriteLine();

            for (int a = 0; a < ListaPortateis.Count; a++)
            {
                    
                writerpc.WriteLine("PORTATIL {0}: ", (a + 1));
                writerpc.WriteLine("Designaçao: " + ListaPortateis[a].DesignacaoBase);
                writerpc.WriteLine("Quantidade: " + ListaPortateis[a].Quantidadep);
                writerpc.WriteLine("Stock Critico: " + ListaPortateis[a].Stock_criticop);
                writerpc.WriteLine("Processador: " + ListaPortateis[a].Processador);
                writerpc.WriteLine("Velocidade_GHz: " + ListaPortateis[a].Velocidade_GHz);
                writerpc.WriteLine("Memoria_RAM: " + ListaPortateis[a].Memoria_RAM);
                writerpc.WriteLine("Disco Rigido: " + ListaPortateis[a].Disco_rigido);
                writerpc.WriteLine("Tamanho do Écran: " + ListaPortateis[a].Tamanho_de_ecran);
                writerpc.WriteLine("Sistema Operativo: " + ListaPortateis[a].Sistema_operativo);
                writerpc.WriteLine("--------------------------------------");
            }

            writerpc.Close();

            StreamWriter writerimp = new StreamWriter("Impressoras.txt");
            writerimp.WriteLine("**Impressoras**");
            writerimp.WriteLine();

            for(int b=0; b<ListaImpressoras.Count;b++)
            {
                writerimp.WriteLine("Impressora {0}: ",(b+1));
                writerimp.WriteLine("Designaçao: " + ListaImpressoras[b].DesignacaoBase);
                writerimp.WriteLine("Quantidade: " + ListaImpressoras[b].Quantidadep);
                writerimp.WriteLine("Stock Critico: " + ListaImpressoras[b].Stock_criticop);
                writerimp.WriteLine("Tecnologia: " + ListaImpressoras[b].Tecnologia);
                writerimp.WriteLine("Formatos Compativeis: " + ListaImpressoras[b].Formatos_compativeis);
                writerimp.WriteLine("Interfaces: " + ListaImpressoras[b].Interfaces);
                writerimp.WriteLine("Plataformas Compativeis: " + ListaImpressoras[b].Plataformas_compativeis);
                writerimp.WriteLine("Peso: " + ListaImpressoras[b].Pesoimp);
                writerimp.WriteLine("Dimensões: " + ListaImpressoras[b].Dimensoesimp);
                writerimp.WriteLine("--------------------------------------");
            }

            writerimp.Close();
               
        }

        private void MostrarFicheiros_Click(object sender, System.EventArgs e)
        {
            string ficheiro;
            if (combomudaproduto.SelectedIndex == 0)   // Impressoras selecionadas
            {
                ficheiro = "Impressoras.txt";
            }
            else
            {
                ficheiro = "computadores_portateis.txt";
            }

            caixafichtexto.Text = "";

            StreamReader reader = new StreamReader(ficheiro);
            string line;
            do
            {
                line = reader.ReadLine();
                if (line != null)
                    caixafichtexto.Text = caixafichtexto.Text + line + Environment.NewLine;
            } while (line != null);

            reader.Close();
        }

        private void txtFichtexto_TextChanged(object sender, System.EventArgs e)
        {

        }


        
       
    }
}
