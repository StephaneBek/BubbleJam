using UnityEngine;
using System.Collections.Generic;

public class PlayerSkills : MonoBehaviour
{
    public List<Skill> skills;

    void Start()
    {
        // Initialize some skills (for example purposes)
        skills = new List<Skill>
        {
            new Skill { skillName = "Strength", level = 1, maxLevel = 5, effectModifier = 1.0f },
            new Skill { skillName = "Agility", level = 1, maxLevel = 5, effectModifier = 1.0f },
        };
    }

    public void UpgradeSkill(string skillName)
    {
        Skill skill = skills.Find(s => s.skillName.Equals(skillName));

        if (skill != null && skill.level < skill.maxLevel)
        {
            skill.level++;
            skill.effectModifier += 0.2f; // Increase skill effect (example modifier)
            Debug.Log($"{skillName} upgraded to level {skill.level}");
        }
        else
        {
            Debug.Log($"{skillName} is already at max level or not found.");
        }
    }
}
