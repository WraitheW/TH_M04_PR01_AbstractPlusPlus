using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iDish
{
    string getType();
    string getNationality();

    string getServed();
}

public class BasicDish : iDish
{
    private string m_course = "default";
    private string m_nationality = "default";
    private string m_served = "default";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }

    public string getServed()
    {
        return m_served;
    }
}


public class pho : iDish
{
    private string m_course = "main";
    private string m_nationality = "Vietnam";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class banhMi : iDish
{
    private string m_course = "main";
    private string m_nationality = "Vietnam";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class jjamppong : iDish
{
    private string m_course = "main";
    private string m_nationality = "Korea";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class naengmyeon : iDish
{
    private string m_course = "main";
    private string m_nationality = "Korea";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class gumbo : iDish
{
    private string m_course = "main";
    private string m_nationality = "USA";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class pastaSalad : iDish
{
    private string m_course = "main";
    private string m_nationality = "USA";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class chaGio : iDish
{
    private string m_course = "side";
    private string m_nationality = "Vietnam";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class goiCuon : iDish
{
    private string m_course = "side";
    private string m_nationality = "Vietnam";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class japchae : iDish
{
    private string m_course = "side";
    private string m_nationality = "Korea";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class kimchi : iDish
{
    private string m_course = "side";
    private string m_nationality = "Korea";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class biscuits : iDish
{
    private string m_course = "side";
    private string m_nationality = "USA";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class cobbSalad : iDish
{
    private string m_course = "side";
    private string m_nationality = "USA";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class cheBaMau : iDish
{
    private string m_course = "dessert";
    private string m_nationality = "Vietnam";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class xiMa : iDish
{
    private string m_course = "dessert";
    private string m_nationality = "Vietnam";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class patbingsu : iDish
{
    private string m_course = "dessert";
    private string m_nationality = "Korea";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class nurungji : iDish
{
    private string m_course = "dessert";
    private string m_nationality = "Korea";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class sundae : iDish
{
    private string m_course = "dessert";
    private string m_nationality = "USA";
    private string m_served = "cold";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}

public class chocoChipCookie : iDish
{
    private string m_course = "dessert";
    private string m_nationality = "USA";
    private string m_served = "hot";

    public string getType()
    {
        return m_course;
    }

    public string getNationality()
    {
        return m_nationality;
    }
    public string getServed()
    {
        return m_served;
    }
}