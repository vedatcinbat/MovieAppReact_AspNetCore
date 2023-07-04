import React, { useState, useEffect } from "react";
import axios from "axios";
function PostMovie() {
  
  const [movieTitle, setMovieTitle] = useState("");
  const [movieGenre, setMovieGenre] = useState("");
  const [movieYear, setMovieYear] = useState("");
  const [movieImdbScore, setMovieImdbScore] = useState("");
  const [movieMetaScore, setMovieMetaScore] = useState("");
  const [movieDescription, setMovieDescription] = useState("");
  const [movieDirector, setMovieDirector] = useState("");
  const [movieCasts, setMovieCasts] = useState("");

  const postFunction = () => {
    const newMoviePost = {
      movieTitle: movieTitle,
      movieGenre: movieGenre,
      movieYear: movieYear,
      movieImdbScore: movieImdbScore,
      movieMetaScore: movieMetaScore,
      movieDescription: movieDescription,
      movieDirector: movieDirector,
      movieCasts: movieCasts
    };

    axios.post("http://localhost:5264/api/movies", newMoviePost)
    .then(res => {
      console.log("Post has been posted successfully : " + res);
      alert("Your movie has been added. Please turn back to the home page !");
    })




  };




  /* const handleInput = (event) => {
    const {name, value} = event.target;
    setMovie({
      ...movie,
      [name]: value,
      })
  } */

  return (
    <div className="m-2">
      <h2 className="mb-2">Post movie</h2>
      
        <div className="flex flex-col w-[15rem] text-center gap-2 p-2 bg-sky-300">
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieTitle"
            onChange={(e) => setMovieTitle(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieGenre"
            onChange={(e) => setMovieGenre(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieYear"
            onChange={(e) => setMovieYear(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieImdbScore"
            onChange={(e) => setMovieImdbScore(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieMetaScore"
            onChange={(e) => setMovieMetaScore(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieDescription"
            onChange={(e) => setMovieDescription(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieDirector"
            onChange={(e) => setMovieDirector(e.target.value)}
          />
          <input
            className="bg-black text-white p-2"
            type="text"
            placeholder="MovieCasts"
            onChange={(e) => setMovieCasts(e.target.value)}
          />
        </div>
        <button type="submit" className="bg-sky-800 text-white p-2" onClick={postFunction}>
          Post
        </button>
      
    </div>
  );
}

export default PostMovie;
