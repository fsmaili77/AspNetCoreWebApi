import { Injectable } from '@angular/core';
import { City } from '../models/city';

@Injectable({
  providedIn: 'root'
})
export class CitiesService {
  cities: City[] = [];
  constructor() {
    this.cities = [
      new City("101", "New York"),
      new City("102", "Paris"),
      new City("103", "London"),
      new City("104", "Berlin"),
    ]
  }

  public getCities(): City[] {
    return this.cities;
  }
}
