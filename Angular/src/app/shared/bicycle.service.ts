import { Injectable } from '@angular/core';
import { Bicycle } from './bicycle.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BicycleService {
  formData: Bicycle;
  readonly rootURL = 'http://localhost:49729/api';
  AvailableBicycles: Bicycle[];
  RentedBicycles: Bicycle[];
  TotalBicyclesPrice:number;
  TotalBicyclesAmount:number;

  constructor(public http: HttpClient) { }

  CreateBicycle() {
    return this.http.post(this.rootURL + '/Bicycles/PostBicycle', this.formData)
  }

  DeleteBicycle(id) {
    return this.http.delete(this.rootURL + '/Bicycles/DeleteBicycle/' + id)
  }

  RentBicycle(id) {
    return this.http.put(this.rootURL + '/Bicycles/RentBicycle/' + id, id)
  }

  CancelRentBicycle(id) {
    return this.http.put(this.rootURL + '/Bicycles/CancelRentBicycle/' + id, id)
  }

  GetTotalBicyclesPrice(){
    this.http.get(this.rootURL + '/Bicycles/GetTotalBicyclesPrice')
    .toPromise()
    .then(res=>this.TotalBicyclesPrice = res as number);
  }

  GetTotalBicyclesAmount(){
    this.http.get(this.rootURL + '/Bicycles/GetTotalBicyclesAmount')
    .toPromise()
    .then(res=>this.TotalBicyclesAmount = res as number);
  }

  GetFreeBicycles() {
    this.http.get(this.rootURL + '/Bicycles/GetFreeBicycles')
      .toPromise()
      .then(res => this.AvailableBicycles = res as Bicycle[]);
  }

  GetRentedBicycles() {
    this.http.get(this.rootURL + '/Bicycles/GetRentedBicycles')
      .toPromise()
      .then(res => this.RentedBicycles = res as Bicycle[]);
  }
}
