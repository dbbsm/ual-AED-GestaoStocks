using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
// AED2.0
namespace RUC__FERNANDO_TOMAS_DIOGO
{
    using System;
    using System.IO;

    [Serializable]
    abstract class Produto_em_Stock
    {
        private string designacaoBase;
        private int quantidadep;
        private string unidade_de_quantidade;
        private string descricaop;
        private string fornecedorp;
        private int stock_criticop;
        private static int quantidadeProdutosemstock;
       

        public Produto_em_Stock(string designacaoBase, int quantidadep, string unidade_de_quantidade, string descricaop, string fornecedorp,int stock_criticop)
        {
            this.designacaoBase = designacaoBase;
            this.quantidadep = quantidadep;
            this.unidade_de_quantidade = unidade_de_quantidade;
            this.descricaop = descricaop;
            this.fornecedorp = fornecedorp;
            this.stock_criticop = stock_criticop;
            quantidadeProdutosemstock++;
        }

        public Produto_em_Stock() { }

        

        public string DesignacaoBase { get; set; }
        public int Quantidadep { get; set; }
        public string Unidade_de_quantidade { get; set; }
        public string Descricaop { get; set; }
        public string Fornecedorp { get; set; }
        public int Stock_criticop { get; set; }

        ~Produto_em_Stock() { }

        public virtual string Display()
        {
            return ("Designacao: " + DesignacaoBase + "\nQuantidade: " + Quantidadep + "\nUnidade de Quantidade: " + Unidade_de_quantidade + "\nDescricao: " + Descricaop + "\nFornecedor: " + Fornecedorp);
        }

        public virtual int afixaquantidades()
        {
            return quantidadeProdutosemstock;
        }

    }

    [Serializable]
    class Computador_Portatil : Produto_em_Stock
    {
        private string processador;
        private double velocidade_GHz;
        private int memoria_RAM;
        private double memoria_cache;
        private int disco_rigido;
        private int velocidade_de_rotacao;
        private double tamanho_de_ecran;
        private string resolucao;
        private string outras_caracteristicas_ecran;
        private string sistema_operativo;
        private string placa_grafica;
        private string leitor_gravador;
        private int portas_USB;
        private string portas_video;
        private string leitor_de_cartoes;
        private string audio;
        private string colunas;
        private string bluetooth;
        private string rede;
        private string acessorios;
        private string software;
        private string dimensoespc;
        private double pesopc;
        private string descricaopc;
        
       

        public Computador_Portatil(): base() 
        {
            
        
        }// const

        public Computador_Portatil(string processador, double velocidade_GHz, int memoria_RAM, double memoria_cache,
        int disco_rigido, int velocidade_de_rotacao, double tamanho_de_ecran, string resolucao, string outras_caracteristicas_ecran,
        string sistema_operativo, string placa_grafica, string leitor_gravador, int portas_USB, string portas_video, string leitor_de_cartoes,
        string audio, string colunas, string bluetooth, string rede, string acessorios, string software, string dimensoespc, double pesopc,
        string descricaopc, string designacaoBase , int quantidadep, string unidade_de_quantidade, string descricaop, string fornecedorp, int stock_criticop) //construtor com argumentos
            : base(designacaoBase, quantidadep, unidade_de_quantidade, descricaop, fornecedorp, stock_criticop)
        {
            this.processador = processador;
            this.velocidade_GHz = velocidade_GHz;
            this.memoria_RAM = memoria_RAM;
            this.memoria_cache = memoria_cache;
            this.disco_rigido = disco_rigido;
            this.velocidade_de_rotacao = Velocidade_de_rotacao;
            this.tamanho_de_ecran = tamanho_de_ecran;
            this.resolucao = resolucao;
            this.outras_caracteristicas_ecran = outras_caracteristicas_ecran;
            this.sistema_operativo = sistema_operativo;
            this.placa_grafica = placa_grafica;
            this.leitor_gravador = leitor_gravador;
            this.portas_USB = portas_USB;
            this.portas_video = portas_video;
            this.leitor_de_cartoes = leitor_de_cartoes;
            this.audio = audio;
            this.colunas = colunas;
            this.bluetooth = bluetooth;
            this.rede = rede;
            this.acessorios = acessorios;
            this.software = software;
            this.dimensoespc = dimensoespc;
            this.pesopc = pesopc;
            
        }

        public string Processador { get; set; }
        public double Velocidade_GHz { get; set; }
        public int Memoria_RAM { get; set; }
        public double Memoria_cache { get; set; }
        public int Disco_rigido { get; set; }
        public int Velocidade_de_rotacao { get; set; }
        public double Tamanho_de_ecran { get; set; }
        public string Resolucao { get; set; }
        public string Outras_caracteristicas_ecran { get; set; }
        public string Sistema_operativo { get; set; }
        public string Placa_grafica { get; set; }
        public string Leitor_gravador { get; set; }
        public int Portas_USB { get; set; }
        public string Portas_video { get; set; }
        public string Leitor_de_cartoes { get; set; }
        public string Audio { get; set; }
        public string Colunas { get; set; }
        public string Bluetooth { get; set; }
        public string Rede { get; set; }
        public string Acessorios { get; set; }
        public string Software { get; set; }
        public string Dimensoespc { get; set; }
        public double Pesopc { get; set; }
        public string Descricaopc { get; set; }
      

        ~Computador_Portatil() { }

        public override string Display()
        {
            return ("\n\tProcessador:" + Processador + "\n\tVelocidade (GHz): " + Velocidade_GHz + "\n\tMemoria RAM: " + Memoria_RAM + "\n\tMemoria Cache: " + Memoria_cache + "\n\tDisco Rigido: " + Disco_rigido + "\n\tVelocidade de rotacao: " + Velocidade_de_rotacao + "\n\tTamanho do Ecran: " + Tamanho_de_ecran + "\n\tResolucao: " + Resolucao + "\n\tOutras caracteristicas do Ecran: " + Outras_caracteristicas_ecran + "\n\tSistema Operativo: " + Sistema_operativo + "\n\tPlaca Grafica: " + Placa_grafica + "\n\tLeitor/Gravador: " + Leitor_gravador + "\n\tPortas USB: " + Portas_USB + "\n\tPortas de Video: " + Portas_video + "\n\tLeitor de Cartoes: " + Leitor_de_cartoes + "\n\tAudio: " + Audio + "\n\tColunas: " + Colunas + "\n\tBluetooth: " + Bluetooth + "\n\tRede: " + Rede + "\n\tAcessorios: " + Acessorios + "\n\tSoftware: " + Software + "\n\tDimensoes: " + Dimensoespc + "\n\tPeso: " + Pesopc + "\n\tDescricao: " + Descricaopc +"\n\tDesignação: "+DesignacaoBase+"\n\tQuantidade: "+Quantidadep+"\n\tUnidade de Quantidade: "+Unidade_de_quantidade+"\n\tFornecedor:"+ Fornecedorp+"\n\tStock Critico: "+Stock_criticop);
        }

       

    }

    [Serializable]
    class Impressora : Produto_em_Stock
    {
        private string tipo;
        private string tecnologia;
        private string cor;
        private string formatos_compativeis;
        private string tipo_de_scanner;
        private string funcao_fotocopiadora;
        private string caracteristicas_impressao;
        private string interfaces;
        private string plataformas_compativeis;
        private int pesoimp;
        private string dimensoesimp;
        

        public Impressora(string tipo, string tecnologia, string cor, string formatos_compativeis, string tipo_de_scanner, string funcao_fotocopiadora,
        string caracteristicas_impressao, string interfaces, string plataformas_compativeis, int pesoimp,string dimensoesimp, string designacaoBase, int quantidadep,
        string unidade_de_quantidade, string descricaop, string fornecedorp, int stock_criticop)
            : base(designacaoBase, quantidadep, unidade_de_quantidade, descricaop, fornecedorp, stock_criticop) //construtor com argumentos
        {

            this.tipo = tipo;
            this.tecnologia = tecnologia;
            this.cor = cor;
            this.formatos_compativeis = formatos_compativeis;
            this.tipo_de_scanner = tipo_de_scanner;
            this.funcao_fotocopiadora = funcao_fotocopiadora;
            this.caracteristicas_impressao = caracteristicas_impressao;
            this.interfaces = interfaces;
            this.plataformas_compativeis = plataformas_compativeis;
            this.pesoimp = pesoimp;
            this.dimensoesimp = dimensoesimp;
            
        }

        public Impressora() : base() 
        {
            
        }

        public string Tipo { get; set; }
        public string Tecnologia { get; set; }
        public string Cor { get; set; }
        public string Formatos_compativeis { get; set; }
        public string Tipo_de_scanner { get; set; }
        public string Funcao_fotocopiadora { get; set; }
        public string Caracteristicas_impressao { get; set; }
        public string Interfaces { get; set; }
        public string Plataformas_compativeis { get; set; }
        public double Pesoimp { get; set; }
        public string Dimensoesimp { get; set; }

        ~Impressora() { }

        public override string Display()
        {
            return ("\n\tTipo: " + Tipo + "\n\tTecnologia: " + Tecnologia + "\n\tCor: " + Cor + "\n\tFormatos Compativeis: " + Formatos_compativeis + "\n\tTipo de Scanner: " + Tipo_de_scanner + "\n\tFuncao da Fotocopiadora: " + Funcao_fotocopiadora + "\n\tCaracteristicas de Impressao: " + Caracteristicas_impressao + "\n\tInterfaces :" + Interfaces + "\n\tPlataformas Compativeis: " + Plataformas_compativeis + "\n\tPeso: " + Pesoimp + "\n\tDimensoes: " + Dimensoesimp + "\n\tDesignação: " + DesignacaoBase + "\n\tQuantidade: " + Quantidadep +"\n\tUnidade de Quantidade: "+Unidade_de_quantidade+"\n\tDescrição: "+Descricaop+ "\n\tFornecedor:" + Fornecedorp+"\n\tStock Critico: "+Stock_criticop);
        }

        

    }

    [Serializable]
    abstract class Contacto
    {
        private string nome_organizacao;
        private string morada;
        private int telefone;
        private string email;
        private string site;
        private int telemovel;
        private string pessoa_de_contacto;
        

        public Contacto(string nome_organizacao, string morada, int telefone, string email, string site, int telemovel, string pessoa_de_contacto)
        {
            this.Nome_organizacao = nome_organizacao;
            this.Morada = morada;
            this.Telefone = telefone;
            this.Email = email;
            this.Site = site;
            this.Telemovel = telemovel;
            this.Pessoa_de_contacto = pessoa_de_contacto;
           
        }

        public Contacto() { }

        public string Nome_organizacao { get; set; }
        public string Morada { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int Telemovel { get; set; }
        public string Pessoa_de_contacto { get; set; }

        ~Contacto() { }

        public virtual string Display()
        {
            return ("");
        }

        
    }

    [Serializable]
    class fornecedor : Contacto//classe fornecedor que deriva da contacto 
    {
        private string tipo_de_material;
        

        public fornecedor(string tipo_de_material, string nome_organizacao, string morada, int telefone, string email, string site, int telemovel, string pessoa_de_contacto)
            : base(nome_organizacao, morada, telefone, email, site, telemovel, pessoa_de_contacto)
        {
            this.tipo_de_material = tipo_de_material;
            
        }

        public fornecedor() : base()
        {
            
        }

        public string Tipo_de_material { get; set; }

        ~fornecedor() { }

        public override string Display()
        {
            return ("\n\tNome da Organizaçao: " + Nome_organizacao + "\n\tMorada: " + Morada + "\n\tTelefone: " + Telefone + "\n\tEmail: " + Email + "\n\tSite: " + Site + "\n\tTelemovel: " + Telemovel + "\n\tPessoa de Contacto: " + Pessoa_de_contacto + "\n\tTipo de Material: " + Tipo_de_material);
        }

        
    }

    [Serializable]
    class Departamento_requisitante : Contacto//classe departamento que contem os seus atributos e métodos
    {
        private double numeros_funcionarios;
        private string area_departamental;
        

        public Departamento_requisitante(double numeros_funcionarios, string area_departamental, string nome_organizacao, string morada, int telefone,
        string email, string site, int telemovel, string pessoa_de_contacto)
            : base(nome_organizacao, morada, telefone, email, site, telemovel, pessoa_de_contacto)
        {
            this.numeros_funcionarios = numeros_funcionarios;
            this.area_departamental = area_departamental;
            
        }

        public Departamento_requisitante() : base() 
        {
            
        }

        public string Numeros_funcionarios { get; set; }
        public string Area_departamental { get; set; }

        ~Departamento_requisitante() { }

        public override string Display()
        {
            return ("\n\tNome da Organizacao: " + Nome_organizacao + "\n\tMorada: " + Morada + "\n\tTelefone: " + Telefone + "\n\tEmail: " + Email + "\n\tSite: " + Site + "\n\tTelemovel: " + Telemovel + "\n\tPessoa de Contacto: " + Pessoa_de_contacto + "\n\tNumero de Funcionarios: " + Numeros_funcionarios + "\n\tArea Departamental: " + Area_departamental);
        }

        
    }

   
    static class Program
    {
       
        
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           

            

      
            

        }

        
    }

   
}
