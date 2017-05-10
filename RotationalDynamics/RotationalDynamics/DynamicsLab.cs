using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationalDynamics
{
    public class DynamicsLab
    {
        //consts for problem
        double m1 = 1.2;
        double m2 = 4.9;
        double r = .35;

        //linear vectors
        Vector3D CoM = new Vector3D();
        Vector3D force = new Vector3D();
        Vector3D vel = new Vector3D();
        Vector3D acc = new Vector3D();
        Vector3D torque = new Vector3D();

        //time vars
        double appliedForce;
        double timestep = 0.02;
        double time = 0.0;
        double endTime;

        //angular vars
        double MoI;
        double Θ;
        double ω;
        double α;

        
        public void Run()
        {
            //get the force magnitude
            Console.Write("Enter the force applied on the object: ");
            appliedForce = Convert.ToDouble(Console.ReadLine());

            //set force vector
            force.SetRectGivenPolar(appliedForce, 30);
            //with force, get what the constant acc will be
            acc = (1 / (m1 + m2)) & force;

            //get total time it will run
            Console.Write("How long is the force being applied: ");
            endTime = Convert.ToDouble(Console.ReadLine());

            //calc r1
            Vector3D r1 = new Vector3D(-(m2*r/(m1+m2)), 0, 0);

            //calc moment of inertia
            MoI = m1 * r1.GetMagnitude() * r1.GetMagnitude() + m2 * (r- r1.GetMagnitude()) * (r - r1.GetMagnitude());

            //FEM
            while(time < endTime)
            {
                //linear
                CoM += vel & timestep;
                vel += acc & timestep;

                //angular
                Θ += ω * timestep;
                ω += α * timestep;

                //get new torque and α
                torque = Vector3D.CrossProduct(r1, force);
                α = torque.GetZ() / MoI;
                r1.SetRectGivenPolar(r1.GetMagnitude(), Θ);
            }
        }
    }
}
