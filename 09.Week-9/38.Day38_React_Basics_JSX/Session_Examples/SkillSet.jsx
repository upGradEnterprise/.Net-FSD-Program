
function SkillSet() {

        let skillsArray = ["HTML5", "CSS3", "JavaScript", "Angular", "React", ];


        let skillList = skillsArray.map( (x) =>  <li>{x}</li> );  
         

  return (
    <>       
        <h2>My Skill Set</h2>

        <ul>
             {skillList}            
        </ul>


    </>)
}

export default SkillSet;