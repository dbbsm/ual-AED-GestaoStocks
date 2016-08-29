using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RUC__FERNANDO_TOMAS_DIOGO
{
    abstract class Produto_em_Stock
    {
        private string designacaoBase;
        private int quantidade;
        private string unidade_de_quantidade;
        private string descricaop;
        private string fornecedor;
        private static int quantidadeProdutosemstock;
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
        private int quantidadeimpressoras;

        public Produto_em_Stock(string designacao, int quantidade, string unidade_de_quantidade, string descricaop, string fornecedor)
        {
            this.designacaoBase = designacao;
            this.quantidade = quantidade;
            this.unidade_de_quantidade = unidade_de_quantidade;
            this.descricaop = descricaop;
            this.fornecedor = fornecedor;
            quantidadeProdutosemstock++;
        }

        public Produto_em_Stock(string tipo, string tecnologia, string cor, string formatos_compativeis, string tipo_de_scanner, string funcao_fotocopiadora, string caracteristicas_impressao, string interfaces, string plataformas_compativeis, int pesoimp, int quantidadeimpressoras)
        {
            // TODO: Complete member initialization
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
            this.quantidadeimpressoras = quantidadeimpressoras;
        }

        public string DesignacaoBase { get; set; }
        public int Quantidade { get; set; }
        public string Unidade_de_quantidade { get; set; }
        public string Descricaop { get; set; }
        public string Fornecedor { get; set; }

        ~Produto_em_Stock() { }

        public virtual void Display()
        {

        }

        public virtual int afixaquantidades()
        {
            return quantidadeProdutosemstock;
        }

    }

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
        private string dimensoes;
        private int pesopc;
        private string descricaopc;
        private static int quantidadepc;
        private string desig;

        public Computador_Portatil(string processador, double velocidade_GHz, int memoria_RAM, double memoria_cache,
        int disco_rigido, int velocidade_de_rotacao, double tamanho_de_ecran, string resolucao, string outras_caracteristicas_ecran,
        string sistema_operativo, string placa_grafica, string leitor_gravador, int portas_USB, string portas_video, string leitor_de_cartoes,
        string audio, string colunas, string bluetooth, string rede, string acessorios, string software, string dimensoes, int pesopc,
        string descricaopc, string desig, int quantidade, string unidade_de_quantidade, string descricaop, string fornecedor) //construtor com argumentos
            : base(desig, quantidade, unidade_de_quantidade, descricaop, fornecedor)
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
            this.dimensoes = dimensoes;
            this.peso = pesopc;
            quantidadepc++;
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
        public string Dimensoes { get; set; }
        public int Pesopc { get; set; }
        public string Descricaopc { get; set; }
        public int peso { get; set; }

        ~Computador_Portatil() { }

        public override void Display()
        {
            Console.WriteLine("Computador Portatil:\n\tProcessador: {0}\n\tVelocidade (GHz): {1}\n\tMemoria RAM: {2}\n\tMemoria Cache: {3}\n\tDisco Rigido: {4}\n\tVelocidade de rotacao: {5}\n\tTamanho do Ecran: {6}\n\tResolucao: {7}\n\tOutras caracteristicas do Ecran: {8}\n\tSistema Operativo: {9}\n\tPlaca Grafica: {10}\n\tLeitor/Gravador: {11}\n\tPortas USB: {12}\n\tPortas de Video: {13}\n\tLeitor de Cartoes: {14}\n\tAudio: {15}\n\tColunas: {16}\n\tBluetooth: {17}\n\tRede: {18}\n\tAcessorios: {19}\n\tSoftware: {20}\n\tDimensoes: {21}\n\tPeso: {22}\n\tDescricao: {23}\n",
                processador, velocidade_GHz, memoria_RAM, memoria_cache, disco_rigido, velocidade_de_rotacao,
                tamanho_de_ecran, resolucao, outras_caracteristicas_ecran, sistema_operativo, placa_grafica, leitor_gravador,
                portas_USB, portas_video, leitor_de_cartoes, audio, colunas, bluetooth, rede, acessorios, software, dimensoes, pesopc, descricaopc);
        }

        public override int afixaquantidades()
        {
            return quantidadepc;
        }

    }

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
        private static int quantidadeimpressoras;

        public Impressora(string tipo, string tecnologia, string cor, string formatos_compativeis, string tipo_de_scanner, string funcao_fotocopiadora,
        string caracteristicas_impressao, string interfaces, string plataformas_compativeis, int pesoimp, string desig, int quantidade,
        string unidade_de_quantidade, string descricaop, string fornecedor)
            : base(tipo, tecnologia, cor, formatos_compativeis, tipo_de_scanner, funcao_fotocopiadora, caracteristicas_impressao,
                interfaces, plataformas_compativeis, pesoimp, quantidadeimpressoras) //construtor com argumentos
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
            this.peso = pesoimp;
            quantidadeimpressoras++;
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
        public int Pesoimp { get; set; }
        public int peso { get; set; }

        ~Impressora() { }

        public override void Display()
        {
            Console.WriteLine("Impressora:\n\tTipo: {0}\n\tTecnologia: {1}\n\tCor: {2}\n\tFormatos Compativeis: {3}\n\tTipo de Scanner: {4}\n\tFuncao Fotocopiadora: {5}\n\tCaracteristicas de Impressao: {6}\n\tInterfaces: {7}\n\tPlataformas Compativeis: {8}\n\tPeso: {9}", tipo, tecnologia, cor, formatos_compativeis, tipo_de_scanner, funcao_fotocopiadora, caracteristicas_impressao, interfaces, plataformas_compativeis, pesoimp);
        }

        public override int afixaquantidades()
        {
            return quantidadeimpressoras;
        }

    }

    abstract class Contacto
    {
        private string nome_organizacao;
        private string morada;
        private int telefone;
        private string email;
        private string site;
        private int telemovel;
        private string pessoa_de_contacto;
        private static int quantidadecontactos;

        public Contacto(string nome_organizacao, string morada, int telefone, string email, string site, int telemovel, string pessoa_de_contacto)
        {
            this.Nome_organizacao = nome_organizacao;
            this.Morada = morada;
            this.Telefone = telefone;
            this.Email = email;
            this.Site = site;
            this.Telemovel = telemovel;
            this.Pessoa_de_contacto = pessoa_de_contacto;
            quantidadecontactos++;
        }

        public string Nome_organizacao { get; set; }
        public string Morada { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int Telemovel { get; set; }
        public string Pessoa_de_contacto { get; set; }

        ~Contacto() { }

        public virtual void Display()
        {
            Console.WriteLine("Contacto:\n\tNome(organizacao): {0}\n\tMorada: {1}\n\tTelefone: {2}\n\tE-mail: {3}\n\tSite: {4}\n\tTelemovel: {5}\n\tPessoa: {6}" + nome_organizacao, morada, telefone, email, site, telemovel, pessoa_de_contacto);
        }

        public virtual int afixaquantidades()
        {
            return quantidadecontactos;
        }
    }

    class fornecedor : Contacto
    {
        private string tipo_de_material;
        private static int quantidadefornecedores;

        public fornecedor(string tipo_de_material, string nome_organizacao, string morada, int telefone, string email, string site, int telemovel, string pessoa_de_contacto)
            : base(nome_organizacao, morada, telefone, email, site, telemovel, pessoa_de_contacto)
        {
            this.tipo_de_material = tipo_de_material;
            quantidadefornecedores++;
        }

        public string Tipo_de_material { get; set; }

        ~fornecedor() { }

        public override void Display()
        {
            Console.WriteLine("Fornecedor:\n\tTipo de material: {0}", tipo_de_material);
        }

        public override int afixaquantidades()
        {
            return quantidadefornecedores;
        }
    }

    class Departamento_requisitante : Contacto
    {
        private double numeros_funcionarios;
        private string area_departamental;
        private static int quantidadedepartamentos;

        public Departamento_requisitante(double numeros_funcionarios, string area_departamental, string nome_organizacao, string morada, int telefone,
        string email, string site, int telemovel, string pessoa_de_contacto)
            : base(nome_organizacao, morada, telefone, email, site, telemovel, pessoa_de_contacto)
        {
            this.numeros_funcionarios = numeros_funcionarios;
            this.area_departamental = area_departamental;
            quantidadedepartamentos++;
        }

        public string Numeros_funcionarios { get; set; }
        public string Area_departamental { get; set; }

        ~Departamento_requisitante() { }

        public override void Display()
        {
            Console.WriteLine("Departamento Requisitante:\n\tNumeros de Funcionarios: {0}\n\tArea Departamental: {1}", numeros_funcionarios, area_departamental);
        }

        public override int afixaquantidades()
        {
            return quantidadedepartamentos;
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
