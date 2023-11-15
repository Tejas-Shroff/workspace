import { Component, NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListMovieComponent } from './list-movie/list-movie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';


const routes: Routes = [

  {path: 'ListMovies',component:ListMovieComponent},
  {path:'find',component:FindmovieComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
