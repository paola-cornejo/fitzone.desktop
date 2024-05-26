﻿using Fitzone.Controller.Interfaces;
using Fitzone.EF;
using Fitzone.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Fitzone.Controller
{
    public class SocioController : IControllersSelect<Socio>, IControllersABM<Socio>
    {
        Contexto? contexto = new Contexto();            

        /// <summary>
        /// Obtener todos los socios
        /// </summary>
        /// <returns></returns>
        public List<Socio>? GetAll()
        {
            return contexto.Socio.Include("Barrio").Where(i=>i.anulado == false).ToList();
        }

        /// <summary>
        /// Obtener el socio con un ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Socio? GetById(int id)
        {
            return contexto.Socio.Include("Barrio").Where(i => i.anulado == false).FirstOrDefault(i=>i.idSocio == id);
        }

        /// <summary>
        /// Obtener el primer socio que contenga el texto en el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public Socio? GetByName(string nombre)
        {
            return contexto.Socio.Include("Barrio").FirstOrDefault(i => i.nombre.Contains(nombre) && i.anulado == false);
        }

        /// <summary>
        /// insertar un socio
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public bool Insert(Socio entidad)
        {
            entidad.idSocio = 0;
            try
            {
                //validar que no se repita el DNI
                var existente = contexto.Socio.FirstOrDefault(i => i.numeroDocumento == entidad.numeroDocumento);
                if (existente != null)
                {
                    //existe el DNI
                    throw new Exception("El socio ya existe [DNI]");

                }
                contexto.Add(entidad);
                contexto.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }          
            

        }

        /// <summary>
        /// Actualizar un socio
        /// </summary>
        /// <param name="entidad"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Update(Socio entidad, int id)
        {
            try
            {
                //busco en la BD el objeto a modificar
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.nombre = entidad.nombre;
                actualizar.apellido = entidad.apellido;
                actualizar.calle = entidad.calle;
                actualizar.calleNumero = entidad.calleNumero;
                actualizar.tipoDocumento = entidad.tipoDocumento;
                actualizar.numeroDocumento = entidad.numeroDocumento;
                actualizar.mail = entidad.mail;

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Borrar un socio
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            //Esto borra definitivamente de la BD
            try
            {
                //busco en la BD el objeto a eliminar
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
                if (actualizar == null)
                    return false;

                contexto.Remove(actualizar);                

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Anular un socio, actualizar el campo anualdo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Anular(int id)
        {
            try
            {
                //busco en la BD el objeto a anular
                var actualizar = contexto.Socio.FirstOrDefault(i => i.idSocio == id);
                if (actualizar == null)
                    return false;

                //actualizo los valores
                actualizar.anulado = true;

                contexto.SaveChanges(true);

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
