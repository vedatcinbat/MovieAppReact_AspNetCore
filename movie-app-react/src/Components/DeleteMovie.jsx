import React, {useState, useEffect} from 'react'
import axios from "axios"




function DeleteMovie() {
  const [id, setId] = useState();


  const delMovie = (id) => {
    axios.delete(`http://localhost:5264/api/movies/${id}`)
    .then(res => {
      console.log("Movie has been deleted : " + res);
      
      alert(`This movie id : ${id} has been deleted`);
    }).catch((error) => {
      // Handle error, if needed
      console.error('Error deleting:', error);
    });
  }




  return (
    <div className='m-2'>
      <h2>Delete Movie With Id</h2>
      <input onChange={(e) => setId(e.target.value)} className='bg-black p-2 text-white' type="text" placeholder='Id' />
      <button onClick={() => delMovie(id)} className='bg-sky-900 text-white p-3 ml-2'>Delete That Movie</button>
    </div>
  )
}

export default DeleteMovie