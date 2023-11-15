import { Component, OnInit } from '@angular/core';
import { MovieService } from '../MovieService/movie.service';

@Component({
  selector: 'app-findmovie',
  templateUrl: './findmovie.component.html',
  styleUrls: ['./findmovie.component.css']
})
export class FindmovieComponent implements OnInit {

  constructor(private movieservice : MovieService) { }

  ngOnInit() {
  }

}
