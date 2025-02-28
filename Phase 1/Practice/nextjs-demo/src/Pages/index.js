import React from 'react';

const Home = ({data}) =>{
    return(
        <div>
            <h1> Welcome to Next.js SSR</h1>
            <pre>{JSON.stringify(data,null,2)}</pre>
        </div>
    );
};

export default Home;

export async function getServerSideProps(){
    const res = await fetch('https://jsonplaceholder.typicode.com/posts');
    const data = await res.json();

    return {props:{data}};
}
