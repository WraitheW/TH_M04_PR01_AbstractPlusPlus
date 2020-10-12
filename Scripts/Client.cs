using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    iDish currentDish;

    [Header("Conditionals")]
    public string nationality;
    public string course;
    public string served;

    [Header("Dropdown")]
    public Dropdown N;
    public Dropdown C;
    public Dropdown S;

    [Header("Text")]
    public Text created;

    public Sprite pho;
    public Sprite banhMi;
    public GameObject panel;

    void Update()
    {

    }

    public void ButtonPress()
    {
        if (N.value == 0)
        {
            currentDish = new nVietnam(currentDish);
            nationality = currentDish.getNationality();
        }
        else if (N.value == 1)
        {
            currentDish = new nKorea(currentDish);
            nationality = currentDish.getNationality();
        }
        else
        {
            currentDish = new nUSA(currentDish);
            nationality = currentDish.getNationality();
        }

        if (C.value == 0)
        {
            currentDish = new tMain(currentDish);
            course = currentDish.getType();
        }
        else if (C.value == 1)
        {
            currentDish = new tSide(currentDish);
            course = currentDish.getType();
        }
        else
        {
            currentDish = new tDessert(currentDish);
            course = currentDish.getType();
        }

        if (S.value == 0)
        {
            currentDish = new sHot(currentDish);
            served = currentDish.getServed();
        }
        else
        {
            currentDish = new sCold(currentDish);
            served = currentDish.getServed();
        }

        DishSpecifications specs = new DishSpecifications();
        specs.Nationality = currentDish.getNationality();
        specs.Course = currentDish.getType();
        specs.Served = currentDish.getServed();

        iDish dish = GetDish(specs);
        created.text = dish.ToString();
        panel.GetComponent<Image>().sprite = Resources.Load<Sprite>(dish.ToString());
    }

    public static iDish GetDish(DishSpecifications specs)
    {
        DishFactory factory = new DishFactory(specs);
        return factory.Create();
    }

}
