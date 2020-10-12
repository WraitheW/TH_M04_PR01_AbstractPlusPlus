using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class DishDecorator : iDish
{
    protected iDish m_tastyDish;

    public DishDecorator(iDish dish)
    {
        m_tastyDish = dish;
    }

    public virtual string getType()
    {
        return m_tastyDish.getType();
    }
    public virtual string getNationality()
    {
        return m_tastyDish.getNationality();
    }

    public virtual string getServed()
    {
        return m_tastyDish.getServed();
    }
}

public class nVietnam : DishDecorator
{
    string Nationality = "Vietnam";

    public nVietnam(iDish dish) : base(dish) { }

    public override string getNationality()
    {
        return Nationality;
    }
}

public class nKorea : DishDecorator
{
    string Nationality = "Korea";

    public nKorea(iDish dish) : base(dish) { }

    public override string getNationality()
    {
        return Nationality;
    }
}

public class nUSA : DishDecorator
{
    string Nationality = "USA";

    public nUSA(iDish dish) : base(dish) { }

    public override string getNationality()
    {
        return Nationality;
    }
}

public class tMain : DishDecorator
{
    string Type = "main";

    public tMain(iDish dish) : base(dish) { }

    public override string getType()
    {
        return Type;
    }
}

public class tSide : DishDecorator
{
    string Type = "side";

    public tSide(iDish dish) : base(dish) { }

    public override string getType()
    {
        return Type;
    }
}

public class tDessert : DishDecorator
{
    string Type = "dessert";

    public tDessert(iDish dish) : base(dish) { }

    public override string getType()
    {
        return Type;
    }
}

public class sHot : DishDecorator
{
    string Served = "hot";

    public sHot(iDish dish) : base(dish) { }

    public override string getServed()
    {
        return Served;
    }
}

public class sCold : DishDecorator
{
    string Served = "cold";

    public sCold(iDish dish) : base(dish) { }

    public override string getServed()
    {
        return Served;
    }
}