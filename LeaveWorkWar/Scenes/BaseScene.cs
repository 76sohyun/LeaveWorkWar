using System.ComponentModel.Design;

namespace LeaveWorkWar.Scenes;

public abstract class BaseScene
{
    public string name;
    public abstract void Render();
    public abstract void Input();
    public abstract void Update();
    public abstract void Result();
    public virtual void Enter(){}
    public virtual void Exit(){}
    
}