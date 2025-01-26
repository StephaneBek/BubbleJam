using UnityEngine;

public class SkillUpgradeSystem : MonoBehaviour
{
    public PlayerSkills playerSkills;
    public string skillToUpgrade;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            playerSkills.UpgradeSkill(skillToUpgrade);
        }
    }
}
