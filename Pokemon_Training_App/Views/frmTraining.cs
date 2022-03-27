﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_Training_App.Classes;
using Pokemon_Training_App.Data;

namespace Pokemon_Training_App.Views
{
    public partial class frmTraining : Form
    {
        public frmTraining()
        {
            InitializeComponent();
        }

        /** BACKING FIELDS **/
        private Partner[] _partyData = new Partner[6];

        /** HELPERS **/
        private Partner buildPartner(PokemonDataSet.PartnersRow partnersRow)
        {
            // determine favored/hindered stat
            PokemonDataSet.NaturesRow naturesRow = naturesTableAdapter.GetNatureByName(partnersRow.NatureName).First();
            string statBonus = naturesRow.StatBonus;
            string statMalus = naturesRow.StatBonus;

            Pokemon species = new Pokemon();

            // Species data
            species.PokeNumber = partnersRow.PokeNum;
            species.PokeName = partnersRow.PokeName;

            Partner partner = new Partner(species,
                partnersRow.Nickname,
                partnersRow.Level,
                partnersRow.NatureName,
                statBonus,
                statMalus,

                // Stats
                partnersRow.Health,
                partnersRow.Attack,
                partnersRow.Defense,
                partnersRow.SpAttack,
                partnersRow.SpDefense,
                partnersRow.Speed,

                // EVs
                partnersRow.EVHealth,
                partnersRow.EVAttack,
                partnersRow.EVDefense,
                partnersRow.EVSpAttack,
                partnersRow.EVSpDefense,
                partnersRow.EVSpeed
                );

            return partner;
        }

        private void displaySlotData(int slotNum)
        {
            Partner partner = _partyData[slotNum];

            // set values, 
            // IMPORTANT!!!! IF CONTROL NAMES ARE CHANGED ADJUSTMENTS TO BELOW CODE WOULD BE NEEDED
            tlpMembersTable.Controls["lblNickname"      + slotNum].Text = partner.Nickname;
            tlpMembersTable.Controls["picInfected"      + slotNum].Visible = partner.HasPokerus;
            tlpMembersTable.Controls["lblHealthEV"      + slotNum].Text = partner.HealthEV.ToString();
            tlpMembersTable.Controls["lblAttackEV"      + slotNum].Text = partner.AttackEV.ToString();
            tlpMembersTable.Controls["lblDefenseEV"     + slotNum].Text = partner.DefenseEV.ToString();
            tlpMembersTable.Controls["lblSpAttackEV"    + slotNum].Text = partner.SpAttackEV.ToString();
            tlpMembersTable.Controls["lblSpDefenseEV"   + slotNum].Text = partner.SpDefenseEV.ToString();
            tlpMembersTable.Controls["lblSpeedEV"       + slotNum].Text = partner.SpeedEV.ToString();
            tlpMembersTable.Controls["lblTotalEV"       + slotNum].Text = partner.TotalEVs().ToString();
        }

        private void getPartyDataForSlot(int slotNum)
        {
            int id = Party.getIDBySlot(slotNum);
            if (id > -1)
            {
                // slot not empty, get data
                Partner partner = getPartnerData(id);
                _partyData[slotNum] = partner;
            }
        }

        private Partner getPartnerData(int id)
        {
            // get partner from database by ID
            PokemonDataSet.PartnersRow partnersRow = partnersTableAdapter.GetDataByPartnerID(id).First();
            return buildPartner(partnersRow);
        }

        /** EVENTS **/
        private void frmTraining_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                getPartyDataForSlot(i);
                if (_partyData[i] != null)
                {
                    displaySlotData(i);
                }
            }
        }
    }
}
