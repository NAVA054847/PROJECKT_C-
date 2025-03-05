import axios from "axios";

const url = "https://localhost:7102/api";

 export const GetAllPerson = async() => {

    try{
        const res=await axios.get(url+"/PersoneController");
        return res.data
    }
    catch(e){
        throw e;
    }
}