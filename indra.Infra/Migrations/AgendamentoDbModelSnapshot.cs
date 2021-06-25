﻿// <auto-generated />
using System;
using indra.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace indra.Infra.Migrations
{
    [DbContext(typeof(AgendamentoDb))]
    partial class AgendamentoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agendamento.Models.Imagem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Caminho")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<int>("ServicoId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ServicoId");

                b.ToTable("Imagens");
            });

            modelBuilder.Entity("Agendamento.Models.Usuario", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Login")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<int?>("Senha")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<int>("PessoaId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("PessoaId");

                b.ToTable("Usuarios");
            });

            modelBuilder.Entity("Agendamento.Models.Servico", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Descricao")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("Nome")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<decimal>("Valor")
                    .HasColumnType("decimal(65,30)");

                b.HasKey("Id");

                b.ToTable("Servicos");
            });

            modelBuilder.Entity("Agendamento.Models.SituacaoAgendamento", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Situacao")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.HasKey("Id");

                b.ToTable("SituacaoAgendamentos");
            });

            modelBuilder.Entity("Agendamento.Models.Agendamentos", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int>("ClienteId")
                    .HasColumnType("int");

                b.Property<DateTime>("Horario")
                    .HasColumnType("datetime(6)");

                b.Property<int>("ProfissionalId")
                    .HasColumnType("int");

                b.Property<int>("ServicoId")
                    .HasColumnType("int");

                b.Property<int>("SituacaoAgendamentoId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ClienteId");

                b.HasIndex("ProfissionalId");

                b.HasIndex("ServicoId");

                b.HasIndex("SituacaoAgendamentoId");

                b.ToTable("Agendamentos");
            });



            modelBuilder.Entity("Agendamento.Models.Pessoa", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<bool>("Ativo")
                    .HasColumnType("tinyint(1)");

                b.Property<string>("Celular")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("ConfirmacaoSenha")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("Cpf")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<DateTime>("DtAlteracao")
                    .HasColumnType("datetime(6)");

                b.Property<DateTime>("DtCriacao")
                    .HasColumnType("datetime(6)");

                b.Property<DateTime>("DtNascimento")
                    .HasColumnType("datetime(6)");

                b.Property<string>("Email")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("Nome")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("Senha")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<string>("Sexo")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<int>("Tipo")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Pessoas");
            });

            modelBuilder.Entity("AgendamentoPacientes.Models.Agendamentos", b =>
            {
                b.HasOne("AgendamentoPacientes.Models.Pessoa", "Pessoa")
                    .WithMany()
                    .HasForeignKey("ClienteId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Agendamento.Models.Pessoa", "Pessoa")
                    .WithMany()
                    .HasForeignKey("ProfissionalId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Agendamento.Models.Servico", "Servico")
                    .WithMany()
                    .HasForeignKey("ServicoId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Agendamento.Models.SituacaoAgendamento", "SituacaoAgendamento")
                    .WithMany()
                    .HasForeignKey("SituacaoAgendamentoId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Agendamento.Models.ProfissionalServicos", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<int>("ProfissionalId")
                    .HasColumnType("int");

                b.Property<int>("ServicoId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ProfissionalId");

                b.HasIndex("ServicoId");

                b.ToTable("ProfissionalServicos");
            });
#pragma warning restore 612, 618
        }
    }
}