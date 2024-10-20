using Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Items
{
    public class Weapon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Wapentype")]
        public WeaponType Type { get; set; }

        [Required]
        [Display(Name = "Naam")]
        public string Name { get; set; }

        [Display(Name = "Schade")]
        public string Damage { get; set; } // Bijvoorbeeld "1d6", "2d4", etc.

        [Required]
        [Display(Name = "Schadetype")]
        public DamageType DamageType { get; set; }

        [Display(Name = "Eigenschappen")]
        public string Properties { get; set; } // Bijvoorbeeld "Finesse, Light", "Ranged, Two-Handed"

        [Display(Name = "Gewicht (in pond)")]
        public double Weight { get; set; } // Gewicht in pond

        [Display(Name = "Beschrijving")]
        public string Description { get; set; } // Beschrijving van het wapen

        // Constructor zonder parameters
        public Weapon()
        {
        }

        // Constructor met WeaponType parameter
        public Weapon(WeaponType type)
        {
            Type = type;
            Name = type.ToString();
            Properties = "";
            InitializeWeapon();
        }

        public void InitializeWeapon()
        {
            switch (Type)
            {
                // Simple Melee Weapons
                case WeaponType.Club:
                    Damage = "1d4";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Light";
                    Weight = 2;
                    break;

                case WeaponType.Dagger:
                    Damage = "1d4";
                    DamageType = DamageType.Piercing;
                    Properties = "Finesse, Light, Thrown (range 20/60)";
                    Weight = 1;
                    break;

                case WeaponType.Greatclub:
                    Damage = "1d8";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Two-Handed";
                    Weight = 10;
                    break;

                case WeaponType.Handaxe:
                    Damage = "1d6";
                    DamageType = DamageType.Slashing;
                    Properties = "Light, Thrown (range 20/60)";
                    Weight = 2;
                    break;

                case WeaponType.Javelin:
                    Damage = "1d6";
                    DamageType = DamageType.Piercing;
                    Properties = "Thrown (range 30/120)";
                    Weight = 2;
                    break;

                case WeaponType.LightHammer:
                    Damage = "1d4";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Light, Thrown (range 20/60)";
                    Weight = 2;
                    break;

                case WeaponType.Mace:
                    Damage = "1d6";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "";
                    Weight = 4;
                    break;

                case WeaponType.Quarterstaff:
                    Damage = "1d6";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Versatile (1d8)";
                    Weight = 4;
                    break;

                case WeaponType.Sickle:
                    Damage = "1d4";
                    DamageType = DamageType.Slashing;
                    Properties = "Light";
                    Weight = 2;
                    break;

                case WeaponType.Spear:
                    Damage = "1d6";
                    DamageType = DamageType.Piercing;
                    Properties = "Thrown (range 20/60), Versatile (1d8)";
                    Weight = 3;
                    break;

                // Simple Ranged Weapons
                case WeaponType.LightCrossbow:
                    Damage = "1d8";
                    DamageType = DamageType.Piercing;
                    Properties = "Ammunition (range 80/320), Loading, Two-Handed";
                    Weight = 5;
                    break;

                case WeaponType.Dart:
                    Damage = "1d4";
                    DamageType = DamageType.Piercing;
                    Properties = "Finesse, Thrown (range 20/60)";
                    Weight = 0.25;
                    break;

                case WeaponType.Shortbow:
                    Damage = "1d6";
                    DamageType = DamageType.Piercing;
                    Properties = "Ammunition (range 80/320), Two-Handed";
                    Weight = 2;
                    break;

                case WeaponType.Sling:
                    Damage = "1d4";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Ammunition (range 30/120)";
                    Weight = 0.5;
                    break;

                // Martial Melee Weapons
                case WeaponType.Battleaxe:
                    Damage = "1d8";
                    DamageType = DamageType.Slashing;
                    Properties = "Versatile (1d10)";
                    Weight = 4;
                    break;

                case WeaponType.Flail:
                    Damage = "1d8";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "";
                    Weight = 2;
                    break;

                case WeaponType.Glaive:
                    Damage = "1d10";
                    DamageType = DamageType.Slashing;
                    Properties = "Heavy, Reach, Two-Handed";
                    Weight = 6;
                    break;

                case WeaponType.Greataxe:
                    Damage = "1d12";
                    DamageType = DamageType.Slashing;
                    Properties = "Heavy, Two-Handed";
                    Weight = 7;
                    break;

                case WeaponType.Greatsword:
                    Damage = "2d6";
                    DamageType = DamageType.Slashing;
                    Properties = "Heavy, Two-Handed";
                    Weight = 6;
                    break;

                case WeaponType.Halberd:
                    Damage = "1d10";
                    DamageType = DamageType.Slashing;
                    Properties = "Heavy, Reach, Two-Handed";
                    Weight = 6;
                    break;

                case WeaponType.Lance:
                    Damage = "1d12";
                    DamageType = DamageType.Piercing;
                    Properties = "Reach, Special, Two-Handed";
                    Weight = 6;
                    break;

                case WeaponType.Longsword:
                    Damage = "1d8";
                    DamageType = DamageType.Slashing;
                    Properties = "Versatile (1d10)";
                    Weight = 3;
                    break;

                case WeaponType.Maul:
                    Damage = "2d6";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Heavy, Two-Handed";
                    Weight = 10;
                    break;

                case WeaponType.Morningstar:
                    Damage = "1d8";
                    DamageType = DamageType.Piercing;
                    Properties = "";
                    Weight = 4;
                    break;

                case WeaponType.Pike:
                    Damage = "1d10";
                    DamageType = DamageType.Slashing;
                    Properties = "Heavy, Reach, Two-Handed";
                    Weight = 18;
                    break;

                case WeaponType.Rapier:
                    Damage = "1d8";
                    DamageType = DamageType.Piercing;
                    Properties = "Finesse";
                    Weight = 2;
                    break;

                case WeaponType.Scimitar:
                    Damage = "1d6";
                    DamageType = DamageType.Slashing;
                    Properties = "Finesse, Light";
                    Weight = 3;
                    break;

                case WeaponType.Shortsword:
                    Damage = "1d6";
                    DamageType = DamageType.Piercing;
                    Properties = "Finesse, Light";
                    Weight = 2;
                    break;

                case WeaponType.Trident:
                    Damage = "1d6";
                    DamageType = DamageType.Piercing;
                    Properties = "Thrown (range 20/60), Versatile (1d8)";
                    Weight = 4;
                    break;

                case WeaponType.WarPick:
                    Damage = "1d8";
                    DamageType = DamageType.Piercing;
                    Properties = "";
                    Weight = 2;
                    break;

                case WeaponType.Warhammer:
                    Damage = "1d8";
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Versatile (1d10)";
                    Weight = 2;
                    break;

                case WeaponType.Whip:
                    Damage = "1d4";
                    DamageType = DamageType.Slashing;
                    Properties = "Finesse, Reach";
                    Weight = 3;
                    break;

                // Martial Ranged Weapons
                case WeaponType.Blowgun:
                    Damage = "1d4";
                    DamageType = DamageType.Piercing;
                    Properties = "Ammunition (range 25/100), Loading";
                    Weight = 1;
                    break;

                case WeaponType.HandCrossbow:
                    Damage = "1d6";
                    DamageType = DamageType.Piercing;
                    Properties = "Ammunition (range 30/120), Light, Loading";
                    Weight = 3;
                    break;

                case WeaponType.HeavyCrossbow:
                    Damage = "1d10";
                    DamageType = DamageType.Piercing;
                    Properties = "Ammunition (range 100/400), Heavy, Loading, Two-Handed";
                    Weight = 18;
                    break;

                case WeaponType.Longbow:
                    Damage = "1d8";
                    DamageType = DamageType.Piercing;
                    Properties = "Ammunition (range 150/600), Heavy, Two-Handed";
                    Weight = 2;
                    break;

                case WeaponType.Net:
                    Damage = "—"; // Net heeft geen schade
                    DamageType = DamageType.Bludgeoning;
                    Properties = "Special, Thrown (range 5/15)";
                    Weight = 3;
                    break;

                default:
                    throw new NotImplementedException($"Weapon type {Type} is nog niet geïmplementeerd.");
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Damage} {DamageType}) [{Properties}]";
        }
    }
}
