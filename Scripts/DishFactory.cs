using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iDishFactory
{
    iDish Create(DishSpecifications specs);
}

public class VietnameseFactory : iDishFactory
{
    public iDish Create(DishSpecifications specs)
    {
        if (specs.Course == "main")
        {
            if (specs.Served == "hot")
            {
                return new pho();
            }
            else
            {
                return new banhMi();
            }
        }
        else if (specs.Course == "side")
        {
            if (specs.Served == "hot")
            {
                return new chaGio();
            }
            else
            {
                return new goiCuon();
            }
        }
        else
        {
            if (specs.Served == "hot")
            {
                return new xiMa();
            }
            else
            {
                return new cheBaMau();
            }
        }
    }
}

public class KoreanFactory : iDishFactory
{
    public iDish Create(DishSpecifications specs)
    {
        if (specs.Course == "main")
        {
            if (specs.Served == "hot")
            {
                return new jjamppong();
            }
            else
            {
                return new naengmyeon();
            }
        }
        else if (specs.Course == "side")
        {
            if (specs.Served == "hot")
            {
                return new japchae();
            }
            else
            {
                return new kimchi();
            }
        }
        else
        {
            if (specs.Served == "hot")
            {
                return new nurungji();
            }
            else
            {
                return new patbingsu();
            }
        }
    }
}

public class AmericanFactory : iDishFactory
{
    public iDish Create(DishSpecifications specs)
    {
        if (specs.Course == "main")
        {
            if (specs.Served == "hot")
            {
                return new gumbo();
            }
            else
            {
                return new pastaSalad();
            }
        }
        else if (specs.Course == "side")
        {
            if (specs.Served == "hot")
            {
                return new biscuits();
            }
            else
            {
                return new cobbSalad();
            }
        }
        else
        {
            if (specs.Served == "hot")
            {
                return new chocoChipCookie();
            }
            else
            {
                return new sundae();
            }
        }
    }
}

public abstract class AbstractDishFactory
{
    public abstract iDish Create();
}

public class DishFactory : AbstractDishFactory
{
    private readonly iDishFactory _factory;
    private readonly DishSpecifications _specs;

    public DishFactory(DishSpecifications specs)
    {
        if (specs.Nationality == "Vietnam")
        {
            _factory = new VietnameseFactory();
        }
        else if (specs.Nationality == "Korea")
        {
            _factory = new KoreanFactory();
        }
        else
        {
            _factory = new AmericanFactory();
        }
        _specs = specs;
    }

    public override iDish Create()
    {
        return _factory.Create(_specs);
    }
}