import React,{useState} from 'react';
import '../desing/Mydesing.css';
import Todoremove from './Todoremove';


let Todo=()=> {

    const [todo,setTodo]= useState("");
    const [todos,setTodos]=useState([]);
 let addFunction=(todo)=>{
    let tempArray=[]
     tempArray=[...todos]
     tempArray.push(todo)
     setTodos(tempArray)
     setTodo("")
     

 }
 let removeFunction=(konum)=>{
     let tempArray=[]
     tempArray=[...todos]
     tempArray.splice(konum,1)
     setTodos(tempArray)
 

 }
         return (
             
        <div className='container' >
            
            <input value={todo} type="text" onChange={(e)=>setTodo(e.target.value)}/>
            <button className="button1" onClick={()=>addFunction(todo)}>EKLE</button>
            <ul>
                {todos.map((item,index)=>{return <li key={index}>{item}<Todoremove deletetodo= {()=>removeFunction(index)} /></li>})}
            </ul>


        </div>
    )
}

export default Todo
