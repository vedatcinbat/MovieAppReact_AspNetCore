import React ,{ useState, useEffect } from "react";
import AllMovies from "./Components/AllMovies";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "./Components/Home";
import GetWithId from "./Components/GetWithId";
import Layout from "./Components/Layout";
import GetWithGenre from "./Components/GetWithGenre";
import GetWithImdb from "./Components/GetWithImdb";
import GetWithYear from "./Components/GetWithYear";
import DeleteMovie from "./Components/DeleteMovie";
import PostMovie from "./Components/PostMovie";

function App() {



  

  
  return (
    <>
    

      <BrowserRouter>
        <Routes>
        <Route path="/" element={<Layout />}>
          <Route index element={<Home />} />
          <Route path="getid" element={<GetWithId />} />
          <Route path="getgenre" element={<GetWithGenre />} />
          <Route path="getimdb" element={<GetWithImdb />} />
          <Route path="getyear" element={<GetWithYear />} />
          <Route path="postmovie" element={<PostMovie />} />
          <Route path="delmovie" element={<DeleteMovie />} />
        </Route>
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
