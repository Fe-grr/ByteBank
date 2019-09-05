using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank;
            public class ContaCorrente
            {
                public ClienteBanco titular;
                public int agencia;
                public int numero;
                public double saldo = 100;


                public bool Sacar(double valor)
                {
                    if (this.saldo < valor)
                        return false;

                    this.saldo -= valor;
                    return true;
                }

                public void Depositar(double valor)
                {
                   this.saldo += valor;
                }

                public bool Transferir(double valor, ContaCorrente ContaDestino)
                {
                    if (this.saldo < valor)
                        return false;

                    ContaDestino.saldo += valor;
                    this.saldo -= valor;
                       return true;
                }
            }

        