using System;
using System.Collections.Generic;
using System.Text;

namespace _01___carros
{
    internal class Carro
    {
        public string Fabricante;
        public string Modelo;
        public int AnoFabricacao;
        public int AnoModelo;
        public float ValorVenda;

        public Carro(string fabricante, string modelo, int anoFabricacao, int anoModelo, float valorVenda)
        {
            SetFabricante(fabricante);
            SetModelo(modelo);
            SetAnoFabricacao(anoFabricacao);
            SetAnoModelo(anoModelo);
            SetValorVenda(valorVenda);
        }
        void SetFabricante(string fabricante)
        {
            this.Fabricante = fabricante;
        }
        void SetModelo(string modelo)
        {
            this.Modelo = modelo;
        }
        void SetAnoFabricacao(int anoFabricacao)
        {
            this.AnoFabricacao = anoFabricacao;
        }
        void SetAnoModelo(int anoModelo)
        {
            this.AnoModelo = anoModelo;
        }
        public void SetValorVenda(float valorVenda)
        {
            this.ValorVenda = valorVenda;
        }

        string GetFabricante()
        {
            return Fabricante;
        }
        string GetModelo()
        {
            return Modelo;
        }
        int GetAnoFabricacao()
        {
            return AnoFabricacao;
        }
        int GetAnoModelo()
        {
            return AnoModelo;
        }
        float GetValorVenda()
        {
            return ValorVenda;
        }

        public override string ToString()
        {
            return $"Fabricante: {GetFabricante()}\nModelo: {GetModelo()}\nAno de fabricação: {GetAnoFabricacao()}\nAno do modelo: {GetAnoModelo()}\nValor de venda: {GetValorVenda()}";
        }


    }
}
