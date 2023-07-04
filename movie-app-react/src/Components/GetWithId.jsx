import React, { useState, useEffect } from "react";

function GetWithId() {
  const [id, setId] = useState();

  const [movie, setMovie] = useState([]);

  const fetchMovie = () => {
    fetch(`http://localhost:5264/api/movies/${id}`)
      .then((res) => res.json())
      .then((data) => {
        setMovie(data);
      });
  };

  useEffect(() => {
    fetchMovie();
    console.log(movie);
  }, [id]);

  return (
    <>
      <div>
        
        <label>Enter id : </label>
        <input
          onChange={(e) => setId(e.target.value)}
          type="text"
          placeholder="id"
        />
        
        

        {movie.length > 0  ? (
          <div className="bg-violet-800 font-bold text-white p-4 text-center mb-2 m-2">
          {/* <div>Id : {movie[0].movieId}</div> */}
          <div>Title : {movie[0].movieTitle}</div>
          <div>Title : {movie[0].movieGenre}</div>
          <div>Title : {movie[0].movieYear}</div>
          <div>Title : {movie[0].movieImdbScore}</div>
          <div>Title : {movie[0].movieMetaScore}</div>
          <div className="bg-black p-4 mt-2 mb-2 rounded-lg">
            Title : {movie[0].movieDescription}
          </div>
          <div>Title : {movie[0].movieDirector}</div>
          <div>Title : {movie[0].movieCasts}</div>
        </div>
        ) : (
          <>Nothing found</>
        )}

        
      </div>
    </>
  );
}

export default GetWithId;
