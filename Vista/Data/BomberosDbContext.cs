﻿using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Vista.Data.Models.Salidas.Planillas.Incendios;
using Vista.Data.Models.Salidas.Planillas.Servicios;
using Vista.Data.Models.Grupos.Dependencias;
using Vista.Data.Models.Grupos.Brigadas;
using Vista.Data.Models.Grupos.FuerzasIntervinientes;
using Vista.Data.Models.Imagenes;
using Vista.Data.Models.Grupos.Dependencias.Comunicaciones;
using Vista.Data.Models.Vehiculos;
using Vista.Data.Enums.Discriminadores;
using Vista.Data.Models.Personas;
using Vista.Data.Models.Personas.Personal;
using Vista.Data.Models.Personas.Personal.Componentes;
using Vista.Data.Models.Vehiculos.Flota;
using Vista.Data.Models.Vehiculos.Flota.Componentes;
using Vista.Data.Models.Otros;
using Vista.Data.Models.Objetos;
using Vista.Data.Models.Objetos.Componentes;

namespace Vista.Data
{
    public class BomberosDbContext : DbContext
    {
        // Personas
        public DbSet<Bombero> Bomberos { get; set; }
        public DbSet<Damnificado_Salida> Damnificados { get; set; }
        public DbSet<ComisionDirectiva> ComisionDirectivas { get; set; }

        // Personas Assets
        public DbSet<Contacto> Contactos { get; set; }

        // Dependencias (Departamentos)
        public DbSet<Dependencia> Dependencias { get; set; }

        // Vehiculos
        public DbSet<Movil> Moviles { get; set; }
        public DbSet<Vehiculo_Personal> VehiculosPersonales { get; set; }

        // Imagenes
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<Imagen_Personal> ImagenesBomberos { get; set; }
        public DbSet<Imagen_VehiculoSalida> ImagenesVehiculo { get; set; }

        // Seguros
        public DbSet<SeguroSalida> SegurosSalidas { get; set; }
        public DbSet<SeguroVehiculo> SeguroVehiculos { get; set; }

        public DbSet<EmbarcacionAfectada> EmbarcacionesAfectadas { get; set; }
        public DbSet<VehiculoAfectadoAccidente> VehiculosAfectadosAccidentes { get; set; }
        public DbSet<VehiculoAfectadoIncendio> VehiculosAfectadoIncendios { get; set; }
        public DbSet<VehiculoDamnificado> VehiculosDamnificados { get; set; }

        // Salidas 
        public DbSet<Accidente> Accidentes { get; set; }
        public DbSet<FactorClimatico> FactoresClimaticos { get; set; }
        public DbSet<RescatePersona> RescatePersonas { get; set; }
        public DbSet<RescateAnimal> RescateAnimales { get; set; }
        public DbSet<IncendioComercio> IncendiosComercios { get; set; }
        public DbSet<IncendioEstablecimientoEducativo> IncendiosEstablecimientosEducativos { get; set; }
        public DbSet<IncendioEstablecimientoPublico> IncendiosEstablecimientosPublicos { get; set; }
        public DbSet<IncendioForestal> IncendiosForestales { get; set; }
        public DbSet<IncendioHospitalesYClinicas> IncendiosHospitalesYClinicas { get; set; }
        public DbSet<IncendioIndustria> IncendiosIndustrias { get; set; }
        public DbSet<IncendioVivienda> IncendiosViviendas { get; set; }
        public DbSet<ServicioEspecialRetiradoDeObito> ServicioEspecialRetiradoDeObito { get; set; }
        public DbSet<MaterialPeligroso> MaterialesPeligrosos { get; set; }
        public DbSet<ServicioEspecialRepresentacion> ServicioEspecialesRespresentaciones { get; set; }
        public DbSet<ServicioEspecialPrevencion> ServicioEspecialPrevenciones { get; set; }
        public DbSet<ServicioEspecialCapacitacion> ServicioEspecialCapacitacion { get; set; }
        public DbSet<ServicioEspecialColocaciónDriza> ServicioEspecialColocaciónDriza { get; set; }
        public DbSet<ServicioEspecialSuministroAgua> ServicioEspecialSuministroAgua { get; set; }
        public DbSet<ServicioEspecialFalsaAlarma> ServicioEspecialFalsaAlarma { get; set; }
        public DbSet<ServicioEspecialColaboraciónFuerzasSeguridad> ServicioEspecialColaboraciónFuerzasSeguridad { get; set; }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Movil_Salida> MovilesSalida { get; set; }
        public DbSet<BomberoSalida> BomberosSalida { get; set; }
        public DbSet<Limpieza> Limpiezas { get; set; }
        public DbSet<Material> Materiales { get; set; }

        public DbSet<MovimientoMaterial> Movimientos { get; set; }
        public DbSet<Embarcacion> Embarcacion { get; set; }
        public DbSet<Comunicacion> Comunicacion { get; set; }
        public DbSet<AscensoBombero> AscensoBomberos { get; set; }
        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<Sancion> Sanciones { get; set; }
        public DbSet<Novedad> Novedades { get; set; }
        public DbSet<NovedadVehiculo> NovedadesVehiculos { get; set; }

        // Fuerzas

        public DbSet<FuerzaInterviniente> Fuerzas { get; set; }
        public DbSet<Salida_FuerzaInterviniente> fuerzaIntervinientes { get; set; }

        // Brigada

        public DbSet<Brigada> Brigadas { get; set; }
        
        // Tablas para Relacion Muchos a Muchos

        public DbSet<Bombero_Dependencia> bombero_dependencia { get; set; }
        public DbSet<Bombero_Brigada> bombero_brigada { get; set; }

        // Propiedad experimental
        public DbSet<Salida> Salidas { get; set; }

        public BomberosDbContext(DbContextOptions<BomberosDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Foreaneas 1:1 (Imagenes)

            modelBuilder.Entity<Personal>()
                .HasOne(p => p.Imagen)
                .WithOne(pi => pi.Personal)
                .HasForeignKey<Imagen_Personal>(pi => pi.PersonalId); // Clave foránea en ProfileImage

            // Relaciones mucho a muchos

            //Dependencia

            modelBuilder.Entity<Bombero_Dependencia>()
                .HasKey(bd => new { bd.PersonaId, bd.DependenciaId });

            modelBuilder.Entity<Bombero_Dependencia>()
                .HasOne(bd => bd.Bombero)
                .WithMany(b => b.Dependencias)
                .HasForeignKey(bd => bd.PersonaId);

            modelBuilder.Entity<Bombero_Dependencia>()
                .HasOne(bd => bd.Dependencia)
                .WithMany(d => d.Bomberos)
                .HasForeignKey(bd => bd.DependenciaId);

            //Brigadas

            modelBuilder.Entity<Bombero_Brigada>()
            .HasKey(bb => new { bb.PersonaId, bb.BrigadaId }); // Configura la clave primaria compuesta

            modelBuilder.Entity<Bombero_Brigada>()
                .HasOne(bb => bb.Bombero)
                .WithMany(b => b.Brigadas)
                .HasForeignKey(bb => bb.PersonaId);

            modelBuilder.Entity<Bombero_Brigada>()
                .HasOne(bb => bb.Brigada)
                .WithMany(b => b.Bomberos) // Asegúrate de que en Brigada tienes una colección de BomberoBrigada
                .HasForeignKey(bb => bb.BrigadaId);

            //Unique

            //Brigadas

            modelBuilder.Entity<Brigada>()
                .HasIndex(b => b.NombreBrigada)
                .IsUnique();

            //Movil

            modelBuilder.Entity<Movil>()
            .HasIndex(m => m.NumeroMovil)
            .IsUnique();

            //Embarcacion

            modelBuilder.Entity<Embarcacion>()
            .HasIndex(e => e.NumeroMovil)
            .IsUnique();

            //Bombero

            modelBuilder.Entity<Bombero>()
                .HasIndex(b => b.NumeroLegajo)
                .IsUnique();

            // Enum Discriminadores

            modelBuilder.Entity<Persona>()
                .Property(p => p.Tipo)
                .HasConversion<int>();

            modelBuilder.Entity<Seguro>()
                .Property(s => s.Tipo)
                .HasConversion<int>();

            modelBuilder.Entity<Imagen>()
                .Property(i => i.Tipo)
                .HasConversion<int>();

            modelBuilder.Entity<Vehiculo>()
                .Property(v => v.Discriminador)
                .HasConversion<int>();

            modelBuilder.Entity<Salida>()
                .Property(s => s.TipoEmergencia)
                .HasConversion<int>();

            //Discriminacion (Pasada a ENUM)

            modelBuilder.Entity<Persona>()
                .HasDiscriminator(p => p.Tipo)
                .HasValue<Bombero>(TipoPersonal.Bombero)
                .HasValue<ComisionDirectiva>(TipoPersonal.ComisionDirectiva);

            modelBuilder.Entity<Seguro>()
                .HasDiscriminator(s => s.Tipo)
                .HasValue<SeguroSalida>(TipoSeguro.SeguroSalida)
                .HasValue<SeguroVehiculo>(TipoSeguro.SeguroVehiculo);

            modelBuilder.Entity<Imagen>()
                .HasDiscriminator(i => i.Tipo)
                .HasValue<Imagen_Personal>(TipoImagen.ImagenPersonal)
                .HasValue<Imagen_VehiculoSalida>(TipoImagen.ImagenVehiculoSalida);

            modelBuilder.Entity<Salida>()
                .HasDiscriminator(s => s.TipoEmergencia)
                .HasValue<Accidente>(TipoDeEmergencia.Accidente)
                .HasValue<FactorClimatico>(TipoDeEmergencia.FactorClimatico)
                .HasValue<MaterialPeligroso>(TipoDeEmergencia.MaterialPeligroso)
                .HasValue<ServicioEspecialRepresentacion>(TipoDeEmergencia.ServicioEspecialRepresentacion)
                .HasValue<RescateAnimal>(TipoDeEmergencia.RescateAnimal)
                .HasValue<RescatePersona>(TipoDeEmergencia.RescatePersona)
                .HasValue<IncendioComercio>(TipoDeEmergencia.IncendioComercio)
                .HasValue<IncendioEstablecimientoEducativo>(TipoDeEmergencia.IncendioEstablecimientoEducativo)
                .HasValue<IncendioEstablecimientoPublico>(TipoDeEmergencia.IncendioEstablecimientoPublico)
                .HasValue<IncendioForestal>(TipoDeEmergencia.IncendioForestal)
                .HasValue<IncendioHospitalesYClinicas>(TipoDeEmergencia.IncendioHospitalesYClinicas)
                .HasValue<IncendioIndustria>(TipoDeEmergencia.IncendioIndustria)
                .HasValue<IncendioVivienda>(TipoDeEmergencia.IncendioVivienda)
                .HasValue<ServicioEspecialPrevencion>(TipoDeEmergencia.ServicioEspecialPrevencion)
                .HasValue<Incendio>(TipoDeEmergencia.Incendio)
                .HasValue<IncendioAeronaves>(TipoDeEmergencia.IncendioAeronaves)
                .HasValue<ServicioEspecialCapacitacion>(TipoDeEmergencia.ServicioEspecialCapacitacion)
                .HasValue<ServicioEspecialColocaciónDriza>(TipoDeEmergencia.ServicioEspecialColocacionDriza)
                .HasValue<ServicioEspecialSuministroAgua>(TipoDeEmergencia.ServicioEspecialSuministroAgua)
                .HasValue<ServicioEspecialFalsaAlarma>(TipoDeEmergencia.ServicioEspecialFalsaAlarma)
                .HasValue<ServicioEspecialRetiradoDeObito>(TipoDeEmergencia.ServicioEspecialRetiradoDeObito)
                .HasValue<ServicioEspecialColaboraciónFuerzasSeguridad>(TipoDeEmergencia.ServicioEspecialColaboracionFuerzasSeguridad);

            modelBuilder.Entity<Vehiculo>()
                .HasDiscriminator(v => v.Discriminador)
                .HasValue<VehiculoAfectadoAccidente>(TipoVehiculo.VehiculoAfectadoAccidente)
                .HasValue<VehiculoAfectadoIncendio>(TipoVehiculo.VehiculoAfectadoIncendio)
                .HasValue<VehiculoDamnificado>(TipoVehiculo.VehiculoDamnificado)
                .HasValue<Vehiculo_Personal>(TipoVehiculo.VehiculoPersonal)
                .HasValue<Movil>(TipoVehiculo.Movil)
                .HasValue<VehiculoAfectado>(TipoVehiculo.VehiculoAfectado)
                .HasValue<Embarcacion>(TipoVehiculo.Embarcacion);

            // Configuracion de Realaciones al Borrarse

            modelBuilder.Entity<Comunicacion>()
                .HasOne(c => c.Bombero)
                .WithOne(b => b.Handie)
                .HasForeignKey<Bombero>(ei => ei.EquipoId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<Imagen_VehiculoSalida>()
                .HasOne(i => i.Vehiculo)
                .WithOne(v => v.Imagen)
                .HasForeignKey<VehiculoSalida>(v => v.ImagenId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<VehiculoSalida>()
                .HasMany(mo => mo.Incidentes)
                .WithOne(li => li.Vehiculo)
                .HasForeignKey(li => li.VehiculoId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<NovedadBase>()
                .HasOne(n => n.Personal)
                .WithMany(b => b.Novedades)
                .HasForeignKey(n => n.PersonalId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<NovedadVehiculo>()
                .HasOne(n => n.Vehiculo)
                .WithMany(b => b.Novedades)
                .HasForeignKey(n => n.VehiculoId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<Bombero>()
                .HasMany(bo => bo.Incidentes)
                .WithOne(li => li.Encargado)
                .HasForeignKey(li => li.PersonaId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<Bombero>()
                .HasMany(bo => bo.VehiculosEncargado)
                .WithOne(ve => ve.Encargado)
                .HasForeignKey(ve => ve.EncargadoId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder.Entity<Comunicacion>()
                .HasOne(c => c.Movil)
                .WithOne(b => b.HandieMovil)
                .HasForeignKey<Movil>(ei => ei.EquipoId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            // Configuración de la relación uno a muchos entre Salida y MovilSalida
            modelBuilder.Entity<Movil_Salida>()
                .HasOne(ms => ms.Salida)
                .WithMany(s => s.Moviles)
                .HasForeignKey(ms => ms.SalidaId);

            // Configuración de la relación uno a muchos entre Salida y BomberoSalida
            modelBuilder.Entity<BomberoSalida>()
                .HasOne(bs => bs.Salida)
                .WithMany(s => s.CuerpoParticipante) // Asegúrate de que Salida tenga una colección BomberosSalidas
                .HasForeignKey(bs => bs.SalidaId);

            // Enum Conversiones a String - INT
            modelBuilder
                .Entity<Persona>()
                .Property(p => p.Sexo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ComisionDirectiva>()
                .Property(c => c.Grado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
               .Entity<MovimientoMaterial>()
               .Property(m => m.TipoMovimiento)
               .HasConversion<string>()
               .HasMaxLength(255);

            modelBuilder
                .Entity<Bombero>()
                .Property(b => b.Grado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Licencia>()
                .Property(p => p.EstadoLicencia)
                .HasConversion<string>()
                .HasMaxLength(255);
            modelBuilder
                .Entity<Licencia>()
                .Property(p => p.TipoLicencia)
                .HasConversion<string>()
                .HasMaxLength(255);
            modelBuilder
                .Entity<Bombero>()
                .Property(b => b.Dotacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Personal>()
                .Property(b => b.GrupoSanguineo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Bombero>()
                .Property(b => b.Estado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecialRepresentacion>()
                .Property(s => s.TipoRepresentacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecialPrevencion>()
                .Property(s => s.TipoPrevencion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecial>()
                .Property(s => s.TipoOrganizacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<RescateAnimal>()
                .Property(r => r.LugarRescateAnimal)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Salida>()
                .Property(s => s.TipoZona)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Salida>()
                .Property(s => s.CuartelRegion)
                .HasConversion<int>();

            modelBuilder
                .Entity<RescatePersona>()
                .Property(r => r.LugarRescatePersona)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioVivienda>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
            .Entity<AscensoBombero>()
            .Property(b => b.GradoAntiguo)
            .HasConversion<string>()
            .HasMaxLength(255);

            modelBuilder
            .Entity<AscensoBombero>()
            .Property(b => b.GradoAscenso)
            .HasConversion<string>()
            .HasMaxLength(255);


            modelBuilder
                .Entity<IncendioIndustria>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioHospitalesYClinicas>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioForestal>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Sancion>()
                .Property(S => S.TipoSancion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Sancion>()
                .Property(S => S.SacionArea)
                .HasConversion<string>()
                .HasMaxLength(255);


            modelBuilder
                .Entity<IncendioEstablecimientoPublico>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioEstablecimientoEducativo>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioComercio>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioVivienda>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoEvacuacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoSuperficieAfectada)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.SuperficieAfectadaCausa)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoAbertura)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoTecho)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<FactorClimatico>()
                .Property(f => f.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<FactorClimatico>()
                .Property(f => f.Evacuacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<FactorClimatico>()
                .Property(f => f.Superficie)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Accidente>()
                .Property(a => a.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);


            modelBuilder
                .Entity<BomberoSalida>()
                .Property(b => b.Grado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Limpieza>()
                .Property(t => t.Incidente)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incidente>()
                .Property(t => t.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Damnificado_Salida>()
                .Property(d => d.Sexo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<VehiculoSalida>()
                .Property(m => m.Estado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<MaterialPeligroso>()
                .Property(m => m.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Accidente>()
                .Property(a => a.CondicionesClimaticas)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Comunicacion>()
                .Property(c => c.Estado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Movil_Salida>()
                .Property(d => d.DotacionSalida)
                .HasConversion<string>()
                .HasMaxLength(255);
        }
    }
}
