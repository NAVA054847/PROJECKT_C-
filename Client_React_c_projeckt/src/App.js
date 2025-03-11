import React, { useEffect, useState } from 'react';
// import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import { GetAllPerson } from './api.js';
// import UserList from './components/UserList';
// import AddUser from './components/AddUser';
// import Login from './components/Login';
// import UpdateUser from './components/UpdateUser';

function App() {

const [person,setperson]=useState([]);

useEffect(()=>{
    GetAllPerson().then(data=>{ console.log("data:",data)});

},[])

    return (
        <div>
            <h1>persones</h1>
            {
              !person ||  person.length==0?<p>טוען...</p>:
            
            <ul>
                { person.map(p=><li>{p.id}---{p.name}---{p.age}---{p.type}</li>)}
            </ul>
            }
        </div>
 
    );
}

export default App;