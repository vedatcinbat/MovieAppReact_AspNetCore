import React from "react";
import { Outlet, Link } from "react-router-dom";

const Layout = () => {
  return (
    <>
      <div className="text-[3rem] bg-red-200 p-2 m-2 rounded-xl text-center mb-2 ">
        AllMovies
      </div>
      <nav className="navigationBar flex justify-between m-2 p-2 bg-purple-900 text-white">
        <li className="bg-sky-200 text-black p-2 rounded-lg cursor-pointer">
          <Link to="/">Home</Link>
        </li>
        <li className="bg-sky-200 text-black p-2 rounded-lg cursor-pointer">
          <Link to="/getid">Get Movie With Id</Link>
        </li>
        <li className="bg-sky-200 text-black p-2 rounded-lg cursor-pointer">
          <Link to="/getyear">Get Movie With Year</Link>
        </li>
        <li className="bg-sky-200 text-black p-2 rounded-lg cursor-pointer">
          <Link to="/postmovie">Post Movie</Link>
        </li>
        <li className="bg-sky-200 text-black p-2 rounded-lg cursor-pointer">
          <Link to="/delmovie">Delete Movie</Link>
        </li>
      </nav>

      <Outlet />
    </>
  );
};

export default Layout;
