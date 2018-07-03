using SistemaBancario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaBancario.DAO
{
    public class ClientesDAO
    {
        public static clientes Login(string email, string senha)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    clientes cliente = conexao.clientes.SingleOrDefault(cli => cli.senha == senha);
                    if (cliente != null)
                    {
                        return cliente;
                    }
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Cadastrar(clientes cliente)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    conexao.clientes.Add(cliente);
                    conexao.SaveChanges();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static IEnumerable<clientes> Listar()
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    return conexao.clientes.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public static clientes BuscarPorEmail(string email)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    return conexao.clientes.SingleOrDefault(cli => cli.email == email);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public static clientes BuscarId(int id)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    return conexao.clientes.Find(id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Transferir(int idtransf, int idreceb, double quantia)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    clientes transf = BuscarId(idtransf);
                    clientes receb = BuscarId(idreceb);
                    transf.saldo -= quantia;
                    receb.saldo += quantia;
                    conexao.Entry(transf).State = System.Data.Entity.EntityState.Modified;
                    conexao.Entry(receb).State = System.Data.Entity.EntityState.Modified;
                    conexao.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
       
        }

        public static bool Atualizar(clientes cliente)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    clientes ct = conexao.clientes.SingleOrDefault(cli => cli.id == cliente.id);
                    ct.nome = cliente.nome;
                    ct.email = cliente.email;
                    ct.dataNasc = cliente.dataNasc;
                    ct.senha = cliente.senha;
                    ct.saldo = cliente.saldo;
                    conexao.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Deletar(int id)
        {
            try
            {
                using (var conexao = new SistemaBancarioEntities())
                {
                    clientes cliente = conexao.clientes.SingleOrDefault(cli => cli.id == id);
                    conexao.clientes.Remove(cliente);
                    conexao.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}