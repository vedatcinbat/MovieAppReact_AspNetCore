import React, { useState, useEffect } from "react";
import axios from "axios";
import "../../src/App.css";
const AllMovies = () => {
  const [movies, setMovies] = useState([]);

  const fetchData = () => {
    fetch("http://localhost:5264/api/movies")
      .then((res) => res.json())
      .then((data) => {
        setMovies(data);
        console.log(data);
      });
  };

  useEffect(() => {
    fetchData();
    console.log(movies);
  }, []);

  return (
    <>
      
      <div className="grid grid-cols-2 h-[30rem]">
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
      </div>
    </>
  );
};

export default AllMovies;
