using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeesetoDucks_Adapter
{
    public class Target
    {
        public int Health { get; set; }
    }
    public interface IUnit
    {
        void Attack(Target target);
    }

    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }

    public class Zealot : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 8;
        }
    }

    public class Zergling : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 5;
        }
    }

    public class Mario
    {
        public int jumpAttack()
        {
            Console.WriteLine("Mamamia!");
            return 3;
        }
    }
    public class MarioAttack : IUnit
    {
        private readonly Mario _mario;

        public MarioAttack(Mario mario)
        {
            _mario = mario;
        }

        public void Attack(Target target)
        {
            target.Health -= _mario.jumpAttack();
        }
    }
}
