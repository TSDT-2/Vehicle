using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class VehicleSound : MonoBehaviour
{
    public abstract class Vehicle
    {
        public abstract void Go();
    }

    public class Car : Vehicle
    {
        public override void Go()
        {
            Debug.Log("Vroom-Vroom");

        }
    }

    public class Ship : Vehicle
    {
        public override void Go()
        {
            Debug.Log("Too-Too");
        }
    }

    public class Plane : Vehicle
    {
        public override void Go()
        {
            Debug.Log("VhooOoo");
        }
    }

    public void Start()
    {
        Vehicle car = new Car();
        Vehicle ship = new Ship();
        Vehicle plane = new Plane();

        car.Go();
        ship.Go();
        plane.Go();
    }

}
