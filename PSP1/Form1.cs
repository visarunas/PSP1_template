using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSP1
{
    public partial class Form1 : Form
    {
        Entity player = new Entity();
        Entity enemy = new Entity();

        WeaponB sword = new WeaponSword();
        WeaponB spear = new WeaponSpear();
        GunWeapon pistol = new GunWeaponPistol();
        GunWeapon shotgun = new GunWeaponShotgun();

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            richTextBox1.Text += "Attacking enemy\n";
            var damage = sword.GetAttackDamage(player, enemy, random);
            richTextBox1.Text += "Damage to enemy: " + damage + "\n\n";
            enemy.health -= damage;

            richTextBox1.Text += "Enemy attacking Player\n";
            damage = spear.GetAttackDamage(enemy, player, random);
            if (checkBoxBlock.Checked)
            {
                var blockPoints = sword.GetBlockPoints(damage, player, random);
                damage = Math.Max(damage - blockPoints, 0);
            }
            richTextBox1.Text += "Damage to Player: " + damage + "\n";
            player.health -= damage;

            textBox1.Text = "Player health: " + player.health;
            textBox2.Text = "Enemy health: " + enemy.health;


        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            richTextBox1.Text += "Firing at enemy\n";
            var damage = pistol.GetAttackDamage(player, enemy, random);
            richTextBox1.Text += "Damage to enemy: " + damage + "\n\n";
            enemy.health -= damage;

            richTextBox1.Text += "Enemy firing at Player\n";
            damage = shotgun.GetAttackDamage(enemy, player, random);

            richTextBox1.Text += "Damage to Player: " + damage + "\n";
            player.health -= damage;

            textBox1.Text = "Player health: " + player.health;
            textBox2.Text = "Enemy health: " + enemy.health;
        }
    }
}
