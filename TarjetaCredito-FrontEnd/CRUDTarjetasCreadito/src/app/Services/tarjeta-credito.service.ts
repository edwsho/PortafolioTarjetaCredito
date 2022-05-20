import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tarjeta } from '../Models/tarjeta'

@Injectable({
  providedIn: 'root'
})
export class TarjetaCreditoService {

  private baseUrl =environment.baseUrl;

  constructor(private http: HttpClient) { }

  GuardarTarjeta(tarjeta : Tarjeta) :Observable<Tarjeta>{
    return this.http.post( this.baseUrl + "api/Tarjeta/PostTarjetas", tarjeta);
  }

  getAllTarjetas() : Observable<Tarjeta>{
    return this.http.get( this.baseUrl + "api/Tarjeta/GetTarjetas");
  }

  eliminarTarjeta(id : number) : Observable<Tarjeta>{
    console.log(id);
    return this.http.delete( this.baseUrl + "api/Tarjeta/" + id);
  }

  modificarTarjeta(id : number, modifTarjeta : Tarjeta) : Observable<Tarjeta>{
    return this.http.put( this.baseUrl + "api/Tarjeta/" + id, modifTarjeta);
  }


}
