using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateNewMeleeWeapon : MonoBehaviour
{
    private List<BaseMeleeWeapon> newMeleeWeapon = new List<BaseMeleeWeapon>();

    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            CreateMeleeWeapon();
        }
    }

    public void CreateMeleeWeapon()
    {
        for (int i = 0; i < 1; i++)
        {
            newMeleeWeapon.Add(new BaseMeleeWeapon());
        }

        for (int i = 0; i < newMeleeWeapon.Count; i++)
        {
            // make ID number
            newMeleeWeapon[i].ItemID = Random.Range(1, 100);
            // make name
            newMeleeWeapon[i].ItemName = "W" + Random.Range(1, 100);
            // make description
            newMeleeWeapon[i].ItemDescription = "Random weapon made.";
            // makes type and damage type (weapon in this case)
            ChooseMeleeWeaponType(i);
            // make gold value
            newMeleeWeapon[i].ItemGoldValue = Random.Range(1, 5001);
            // make lvl req
            newMeleeWeapon[i].ItemLvlRequirement = Random.Range(1, 31);
            // make damage
            newMeleeWeapon[i].WeaponDamage = Random.Range(0, 101);
            // make attack speed
            newMeleeWeapon[i].WeaponAttackSpeed = Random.Range(0.1f, 2f);
            // is it two handed
            newMeleeWeapon[i].WeaponIsTwoHanded = (Random.value > 0.5f);
            if (newMeleeWeapon[i].MeleeWeaponType == BaseMeleeWeapon.MeleeWeaponTypes.SPEAR || newMeleeWeapon[i].MeleeWeaponType == BaseMeleeWeapon.MeleeWeaponTypes.STAFF)
            {
                newMeleeWeapon[i].WeaponIsTwoHanded = true;
            }
            if (newMeleeWeapon[i].MeleeWeaponType == BaseMeleeWeapon.MeleeWeaponTypes.DAGGER || newMeleeWeapon[i].MeleeWeaponType == BaseMeleeWeapon.MeleeWeaponTypes.WAND)
            {
                newMeleeWeapon[i].WeaponIsTwoHanded = false;
            }
            // long reach?
            newMeleeWeapon[i].MeleeWeaponHasReach = (Random.value > 0.5f);
            if (newMeleeWeapon[i].WeaponIsTwoHanded == false)
            {
                newMeleeWeapon[i].MeleeWeaponHasReach = false;
            }
            if (newMeleeWeapon[i].MeleeWeaponType == BaseMeleeWeapon.MeleeWeaponTypes.SPEAR)
            {
                newMeleeWeapon[i].MeleeWeaponHasReach = true;
            }
            // heavy?
            newMeleeWeapon[i].MeleeWeaponIsHeavy = (Random.value > 0.5f);

            if (newMeleeWeapon[i].MeleeWeaponType == BaseMeleeWeapon.MeleeWeaponTypes.WAND)
            {
                newMeleeWeapon[i].MeleeWeaponIsHeavy = false;
            }
        }

        MeleeWeaponPrint();
    }

    private void ChooseMeleeWeaponType(int arraySpot)
    {
        newMeleeWeapon[arraySpot].ItemType = BaseItem.ItemTypes.WEAPON;
        newMeleeWeapon[arraySpot].WeaponType = BaseWeapon.WeaponTypes.MELEE;

        int randomMeleeType = Random.Range(1, 8);
        switch (randomMeleeType)
        {
            case 1:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.SWORD;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.SLASH;
                break;
            case 2:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.AXE;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.SLASH;
                break;
            case 3:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.MACE;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.BLUNT;
                break;
            case 4:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.SPEAR;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.PIERCE;
                break;
            case 5:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.DAGGER;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.PIERCE;
                break;
            case 6:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.STAFF;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.BLUNT;
                break;
            case 7:
                newMeleeWeapon[arraySpot].MeleeWeaponType = BaseMeleeWeapon.MeleeWeaponTypes.WAND;
                newMeleeWeapon[arraySpot].WeaponDamageType = BaseWeapon.WeaponDamageTypes.BLUNT;
                break;
            default:
                break;
        }
    }

    private void MeleeWeaponPrint()
    {
        for (int i = 0; i < newMeleeWeapon.Count; i++)
        { 
            Debug.Log("ID: " + newMeleeWeapon[i].ItemID);
            Debug.Log("Name: " + newMeleeWeapon[i].ItemName);
            Debug.Log("Description: " + newMeleeWeapon[i].ItemDescription);
            Debug.Log("Gold Value: " + newMeleeWeapon[i].ItemGoldValue);
            Debug.Log("Type: " + newMeleeWeapon[i].ItemType);
            Debug.Log(newMeleeWeapon[i].WeaponType);
            Debug.Log(newMeleeWeapon[i].MeleeWeaponType);
            Debug.Log(newMeleeWeapon[i].WeaponDamageType);
            Debug.Log("Lvl req: " + newMeleeWeapon[i].ItemLvlRequirement);
            Debug.Log("Damage: " + newMeleeWeapon[i].WeaponDamage);
            Debug.Log("Atk Spd: " + newMeleeWeapon[i].WeaponAttackSpeed);
            Debug.Log("Two Handed:" + newMeleeWeapon[i].WeaponIsTwoHanded);
            Debug.Log("Reach: " + newMeleeWeapon[i].MeleeWeaponHasReach);
            Debug.Log("Heavy: " + newMeleeWeapon[i].MeleeWeaponIsHeavy);
        }
    }
}
