import { Injectable, Inject } from '@angular/core';
import { Http, RequestOptions, URLSearchParams, Headers, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/operator/delay';
import 'rxjs/operator/mergeMap';
import 'rxjs/operator/switchMap';
import { of } from 'rxjs/observable/of';
import { map, catchError } from 'rxjs/operators';
import { FilingRequestStatus } from '@app/home/filing-request-status.interface';

@Injectable()
export class ReferenceDataService {

  constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) { }

  getFilingRequestStauses(): Observable<FilingRequestStatus[]> {
    return this.http.get('http://localhost/ngxfrms/api/ReferenceData/GetFilingRequest').map(response => response.json() as FilingRequestStatus[]);
  }

}
