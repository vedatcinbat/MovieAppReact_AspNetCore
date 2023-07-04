import React, {useState, useEffect} from "react";

function GetWithYear() {


  const [movies, setMovies] = useState([]);
  const [year, setYear] = useState(100000);


  


  const getMovies = () => {
    fetch(`http://localhost:5264/api/filteryear/${year}`)
    .then(res => res.json())
    .then(data => {
      setMovies(data);
      console.log(movies);
    })
  }

  useEffect(() => {
    getMovies();
  }, [year])



  return (
    <>
      <form>
        <label>
          Select year for getting movies that released after that year
        </label>
        <input onChange={(e) => setYear(e.target.value)} type="text" placeholder="YEAR" />
      </form>
      
      {movies.length > 0 ? (
          movies.map((item) => (
            <div className="bg-violet-800 font-bold text-white p-4 text-center mb-2 m-2">
              <div>Id : {item.movieId}</div>
              <div>Title : {item.movieTitle}</div>
              <div>Title : {item.movieGenre}</div>
              <div>Title : {item.movieYear}</div>
              <div>Title : {item.movieImdbScore}</div>
              <div>Title : {item.movieMetaScore}</div>
              <div className="bg-black p-4 mt-2 mb-2 rounded-lg">
                Title : {item.movieDescription}
              </div>
              <div>Title : {item.movieDirector}</div>
              <div>Title : {item.movieCasts}</div>
            </div>
          ))
        ) : (
          <p>Loading data...</p>
        )}
          
    </>
  );
}

export default GetWithYear;
