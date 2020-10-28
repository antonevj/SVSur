﻿using SVSur.Manager.Contracts;
using SVSur.Models;
using SVSur.Models.Domain;
using SVSur.Models.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SVSur.Manager
{
    public class RutaManager : IRutaManager
    {

        public IEnumerable<Ruta> GetAll(bool status)
        {
            using (var context = new ApplicationDbContext())
            {
                var lista = context.Rutas.Include("Chofer").Where(K => K.Estado == status).ToList();
                return lista;
            }
        }

        public IEnumerable<RutaDTO> GetAllDTO(bool status)
        {
            using (var context = new ApplicationDbContext())
            {
                var lista = context.Rutas
                    .Where(K => K.Estado == status)
                    .Select(K => new RutaDTO
                    {

                        RutaID = K.RutaID,
                        CiudadOrigen = K.CiudadOrigen,
                        Ciudaddestino = K.CiudadDestino,
                        Precio = K.Precio,
                        Duracion = K.Duracion,
                        FechaViaje = K.FechaViaje,
                        HoraSalida = K.HoraSalida,
                        Nombre = K.Chofer.Nombre,


                    }).ToList();

                return lista;
            }

        }

        public Ruta Get(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Rutas.Where(k => k.RutaID == id).SingleOrDefault();
            }
        }


        public int Insert(Ruta obj)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(obj).State = EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int Update(Ruta obj)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Entry(obj).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }

        public IEnumerable GetAllSimple()
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var obj = context.Rutas.Find(id);
                context.Entry(obj).State = EntityState.Deleted;
                return context.SaveChanges();
            }
        }

    }
}
